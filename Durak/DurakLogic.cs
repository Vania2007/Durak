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
        public DurakLogic(Action showState)
        {
            Deck = new CardSet();
            Deck.Full();
            
            Table = new CardSet();
            ShowState = showState;
        }
        public Action ShowState { get; set; }
        public string Info { get; set; }
        public CardSet Deck { get; set; }
        public List<Player> Players { get; set; }
        public CardSet Table { get; set; }
        public Player Current { get; set; }
        public Player Attacker { get; set; }
        public Player Defender { get; set; }
        public Card Trump { get; set; }// = new Card(Deck.LastCard.Rank, Deck.LastCard.Suit);
        public Player FirstPasser { get; set; }

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
            if(numberOfCurrent+1 == Players.Count)
            {
                return Players[0];
            }
            else
                return Players[numberOfCurrent + 1];
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
        }
        public void GiveUp() //defender says «I give up»
        {
            GameMode = Mode.Toss;
            Current = Attacker;
            Info = "Player is giving up";
            ShowState();
        }
        public void Beat()
        {

            Table.Clear();
            Attacker = NextAttacker(Attacker);
            GameMode = Mode.Attack;
            NextAttacker(Current);
            CardsToBeat = 6;
        }
        public bool PossibleMove(Card movingCard)
        {
            //if mode is defence then card must be greater, if mode is attack or toss then card rank musr be on table or table is empty
            if (GameMode == Mode.Defend)
                return IsGreater(movingCard, Table.LastCard);
            else
            {
                if (Table.Count == 0) return true;
                return IsGreater(movingCard, Table.LastCard);
            }
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
                GameMode = Mode.Attack;
            else if (GameMode == Mode.Attack)
                GameMode = Mode.Defend;
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
            TrumpChoise();
            Attacker = Players[0];
            //Who current? Who attacker? Who defender?
            Attacker = WhoFirst();
            Current = Attacker;
            Defender = Players[1];
            ShowState();
        }
        public void DealUp() 
        {
            //whaT IF deck doesn't have enough cards?
            int counter = 0;
            foreach (var player in Players)
            {
                counter += player.Hand.Count;
            }
            if (counter<=Deck.Count)
            {
                while (Current.Hand.Count < 6)
                {
                    Current.Hand.Add(Deck.Pull());
                    ShowState();
                }
            }
            else if (counter > Deck.Count)
            {
                int separation = counter / Players.Count;
                if (separation <= Players.Count)
                {
                    for (int i = 0; i < separation&&i<Players.Count; i++)
                    {
                        Players[i].Hand.Add(Deck.Pull());
                    }
                }
                else if (separation > Players.Count)
                {
                    for (int i = 0; Deck.Count > 0 ; i++)
                    {
                        Players[i].Hand.Add(Deck.Pull());
                    }
                }
            }
        }
        public void Pass()
        {
            //next attacker not current
            //передає хід наступному гравцю
            for (int i = 0; i < Players.Count+1; i++)
            {
                if (Players[i] != Players[Players.Count + 1])
                    NextAttacker(Current);
                else if (Players[i] == Players[Players.Count + 1])
                    Beat();
            }
        }
        public void EndOfTheGame()
        {
            //Підбиває підсумки гри, повертає "Дурня"(той, хто програв)
            throw new NotImplementedException();
        }
        public Card TrumpChoise()
        {
            return Trump = Deck.LastCard;
        }
    }
}
