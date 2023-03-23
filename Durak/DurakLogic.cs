using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durak
{
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
        public CardSet Deck { get; set; }
        public List<Player> Players { get; set; }
        public CardSet Table { get; set; }
        public Player Current { get; set; }
        public Player Attacker { get; set; }
        public Player Defender { get; set; }
        public Card Trump { get; set; }// = new Card(Deck.LastCard.Rank, Deck.LastCard.Suit);
        public Player FirstPasser { get; set; }

        private int CardsToBeat { get; set; }
        enum Mode
        {
            Attack,
            Defend,
            Toss //підкидання
        }
        public Player WhoFirst()
        {
            Card smallestCard;
            List<Card> trumps = new List<Card>();
            foreach (var player in Players)
            {
                foreach (var card in player.Hand)
                {
                    if(card.Suit == Trump.Suit)
                    {
                        trumps.Add(card);
                    }
                    for (int i = 0; i < trumps.Count; i++)
                    {
                        if (card.Suit == Trump.Suit && card.Rank < trumps[i].Rank)
                        {
                            smallestCard = card;
                            
                        }
                    }
                    Attacker = player;
                    Players[0] = Attacker;
                    
                }
            }
            return Attacker;
        }
        public Player NextPlayer()
        {
            int numberOfCurrent = Players.IndexOf(Current);
            if(numberOfCurrent+1 > Players.Count)
            {
                return Players[(numberOfCurrent + 1) / Players.Count];
            }
            else
                return Players[numberOfCurrent + 1];
        }
        public Player NextAttacker()
        {
            if (NextPlayer() == Defender)
                NextAttacker();
            return NextPlayer();
        }
        public void PickUp()
        {
            GiveUp();
            for (int i = 0; i < Table.Count; i++)
            {
                Defender.Hand.Add(Table.Pull());
            }
        }
        public void GiveUp() //defender says «I give up»
        {
            //Interface
            throw new NotImplementedException();
        }
        public void Beat()
        {

            Table.Clear();
        }
        public bool PossibleMove(Card movingCard)
        {
            throw new NotImplementedException();
        }
        public bool IsGreater(Card tableCard, Card movingCard)
        {
            if (movingCard.Rank > tableCard.Rank)
                return true;
            else if (movingCard.Suit == Trump.Suit && tableCard.Suit != Trump.Suit)
                return true;
            else if (movingCard.Suit == Trump.Suit && tableCard.Suit == Trump.Suit && movingCard.Rank > tableCard.Rank)
                return true;
            else
                return false;
        }
        public void Turn(Card card)
        {

            if (!Current.Hand.Contains(card)) return;
            //if (!PossibleMove(card)) return;
            Table.Add(Current.Hand.Pull(card));
            //Current changing
            Current = Players[Players.IndexOf(Current) + 1];
            ShowState();
        }
        public void NewTurn()
        {
            throw new NotImplementedException();
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
                    NextAttacker();
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
