using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durak
{
    public enum Mode
    {
        Attack,
        Defend,
        Toss //підкидання
    }
    public class DurakLogic
    {
        //Logic
        public DurakLogic(List<Player> players, Action<string> showInfo, Action showState)
        {
            Deck = new CardSet();
            Deck.Full();
            Players = players;
            Table = new CardSet();
            ShowInfo = showInfo;
            ShowState = showState;
            Beated = new CardSet();
        }
        public Action ShowState { get; set; }
        public Action<string> ShowInfo { get; set; }
        public string Info { get; set; }
        public CardSet Deck { get; set; }
        public CardSet Beated { get; set; }
        public List<Player> Players { get; set; }
        public CardSet Table { get; set; }
        public Player Current { get; set; }
        public Player Attacker { get; set; }
        public Player Defender { get; set; }
        public Card Trump { get; set; }
        public Player FirstPasser { get; set; }
        public Player FirstAttacker { get; set; }
        public Mode GameMode { get; set; }

        private int CardsToBeat { get; set; }

        public Player WhoFirst()
        {
            
            Player first = Players[0];
            Card smallestCard = first.Hand[0];
            foreach (var player in Players)
            {
                foreach (var card in player.Hand)
                {
                    if (card.Suit != Trump.Suit) continue;

                    if (smallestCard.Suit != Trump.Suit || card.Rank < smallestCard.Rank)
                    {
                        smallestCard = card;
                        first = player;
                    }
                }
            }
            return first;
        }
        public Player NextPlayer(Player player)
        {
            int numberOfCurrent = Players.IndexOf(player);
            Player candidate;
            if (numberOfCurrent + 1 == Players.Count)
            {
                candidate = Players[0];
            }
            else
            {
                candidate = Players[numberOfCurrent + 1];
            }
            return candidate.InGame?candidate:NextPlayer(candidate);
        }
        public Player NextAttacker(Player currentAttacker)
        {
            Player next = NextPlayer(currentAttacker);
            if (next == Defender)
                return NextAttacker(next);
            return next;
        }
        public void PickUp()
        {
            Defender.Hand.Add(Table.Deal(Table.Count));
            Table.Clear();
            DealUp();
            FirstAttacker = NextPlayer(Defender);
            Defender = NextPlayer(FirstAttacker);
            Current = Attacker = FirstAttacker;
            ShowState();
        }
        public void GiveUp() //defender says «I give up»
        {
            GameMode = Mode.Toss;
            Current = Attacker;
            ShowInfo($"{Current.Name} is giving up");
            ShowState();
        }
        public void Beat()
        {
            Beated.Add(Table.Deal());
            ShowState();
            GameMode = Mode.Attack;
            CardsToBeat = 6;
            DealUp();
            FirstAttacker = NextPlayer(FirstAttacker);
            Defender = NextPlayer(FirstAttacker);
            Current = Attacker = FirstAttacker;
            ShowState();
        }
        public bool PossibleMove(Card movingCard)
        {
            //if mode is defence then card must be greater, if mode is attack or toss then card rank musr be on table or table is empty
            if (GameMode == Mode.Defend)
                return IsGreater(movingCard, Table.LastCard);
           
            if (Table.Count == 0) return true;

            return Table.FirstOrDefault(c => c.Rank == movingCard.Rank) != default;
            
        }
        public bool IsGreater(Card movingCard, Card tableCard)
        {
            if (tableCard.Suit == movingCard.Suit)
                return movingCard.Rank > tableCard.Rank;
            else
                return movingCard.Suit == Trump.Suit;
        }
        public void Turn(Card card)
        {
            
            if (!Current.Hand.Contains(card)) return;
            if (!PossibleMove(card)) return;
            Table.Add(Current.Hand.Pull(card));
            //Current changing
            Current = Current == Attacker ? Defender : Attacker;

            if (GameMode == Mode.Defend)
            {
                CardsToBeat--;
                if (CardsToBeat == 0)
                {
                    Beat();
                    return;
                }
                GameMode = Mode.Attack;
            }
            else if (GameMode == Mode.Attack)
            {
                GameMode = Mode.Defend;
                FirstPasser = null;
            }
            ShowState();
        }


        public void Start()
        {
            Deck.Shuffle();
            foreach (var player in Players)
            {
                player.Hand.Add(Deck.Deal(6));
                player.Hand.Sort();
            }
            CardsToBeat = 5;
            Trump = TrumpChoise();
            //Who current? Who attacker? Who defender?
            FirstAttacker = WhoFirst();
            Current = Attacker = FirstAttacker;
            Defender = NextPlayer(Attacker);
            ShowState();
        }
        public void DealUp() 
        {
            //whaT IF deck doesn't have enough cards?
            foreach (var player in Players)
            {
                if (player.Hand.Count >= 6) continue;
                player.Hand.Add(Deck.Deal(6 - player.Hand.Count));
                player.Hand.Sort(new DurakComparer(Trump.Suit));
            }
            FirstPasser = null;
            CheckEmptyPlayers();
            ShowState();
        }
        private void CheckEmptyPlayers()
        {
            
            foreach (var player in Players)
            {
                player.InGame = player.Hand.Count > 0;
            }
            int countInGame = Players.Count(p => p.InGame);
            if (countInGame < 2)
            {
                EndOfTheGame(Players.FirstOrDefault(p => p.InGame));
            }
        }

        public void Pass()
        {
            //next attacker not current
            //передає хід наступному гравцю
            if (FirstPasser == null)
                FirstPasser = Attacker;
            Current = Attacker = NextAttacker(Attacker);
            if (Attacker == FirstPasser)
            {
                if (GameMode == Mode.Attack)
                    Beat();
                else if (GameMode == Mode.Toss)
                    PickUp();
                ShowState();
                return;
            }
            
            
            Current = Attacker;
            ShowState();


        }
        public void EndOfTheGame(Player durak)
        {
            if (durak == null)
                ShowInfo("Draw");
            else          
                //Підбиває підсумки гри, повертає "Дурня"(той, хто програв)
                ShowInfo($"{durak.Name} lost the game!\n He is a fool");
            
            ShowState();
        }
        public Card TrumpChoise()
        {
            return Trump = Deck.LastCard;
        }
    }
}
