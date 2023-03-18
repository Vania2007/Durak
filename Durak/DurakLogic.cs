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
        public Card Trump { get; set; } = new Card(Deck.LastCard.Rank, Deck.LastCard.Suit);
        public Player FirstPasser { get; set; }

        private int CardsToBeat { get; set; }
        enum Mode
        {
            Attack,
            Defend,
            Toss //підкидання
        }





        //public bool IsGreater(Card tableCard, Card movingCard)
        //public bool PossibleMove(Card movingCard)
        //public void PickUp() 
        //public void GiveUp() defender says «I give up»
        //public void Pass()
        //public PlayerNextPlayer()
        
        //public void Beat()
        //public void NewTurn()


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
                    return player;
                }
            }
        }
        public Player NextAttacker()
        {

        }
        public void Turn(Card card)
        {

            if (!Current.Hand.Contains(card)) return;
            //if (!PossibleMove(card)) return;
            Table.Add(Current.Hand.Pull(card));
            //Current changing
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
            //foreach (var player in Players)
            //{
            //    foreach (var card in player.Hand)
            //    {
            //        if (card.Suit == TrumpChoice())
            //            Players[0] = player;
            //    }
            //}
            ShowState();
        }
        public void DealUp()
        {
            //whaT IF deck doesn't have enough cards?
            while (Current.Hand.Count < 6)
            {
                Current.Hand.Add(Deck.Pull());
                ShowState();
            }
        }
        public void Pass()
        {
            //next attacker not current
            //передає хід наступному гравцю
            //for (int i = 0; i < Players.Count + 1; i++)
            //{
            //    Current = Players[i];
            //    if (i > Players.Count)
            //        i = 0;
            //}
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
