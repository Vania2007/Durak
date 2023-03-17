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
            Player = new Player();
            Table = new CardSet();
            ShowState = showState;
        }
        public Action ShowState { get; set; }
        public CardSet Deck { get; set; }
        public Player Player { get; set; }
        public List<Player> Players { get; set; }
        public CardSet Table { get; set; }
        public Player Current { get; set; }
        public void Turn(Card card)
        {
            if (!Player.Hand.Contains(card)) return;
            Table.Add(Player.Hand.Pull(card));
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
            foreach (var player in Players)
            {
                foreach (var card in player.Hand)
                {
                    if (card.Suit == TrumpChoice())
                        Players[0] = player;
                }
            }
            ShowState();
        }
        public void Hit()
        {
            while (Player.Hand.Count < 6)
            {
                Player.Hand.Add(Deck.Pull());
                ShowState();
            }
        }
        public void Pass()
        {
            //передає хід наступному гравцю
            for (int i = 0; i < Players.Count+1; i++)
            {
                Current = Players[i];
                if (i > Players.Count)
                    i = 0;
            }
        }
        public void EndOfTheGame()
        {
            //Підбиває підсумки гри повертає "Дурня"(той, хто програв)
            throw new NotImplementedException();
        }
        public CardSuit TrumpChoice()
        {
            // and return Card, which shows a trump card in the game
            Card trumpCard = Deck[0];
            return trumpCard.Suit;
        }

    }
}
