using CardLib;
using Durak.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsInfrastructure
{
    public class GraphicsStore
    {
        private static Dictionary<string, Image> cardImages = new Dictionary<string, Image>();
        private Dictionary<Card, PictureBox> pictureBoxes = new Dictionary<Card, PictureBox>();
        private Dictionary<PictureBox, Card> cards = new Dictionary<PictureBox, Card>();

        public Control Parent { get; set; }
        public static Image FaceDownImage { get; private set; }

        static GraphicsStore()
        {
            FaceDownImage = Resources.pattern;
            cardImages[new Card(CardRank.Two, CardSuit.Heart).ToString()] = Resources._2_of_hearts;
            cardImages[new Card(CardRank.Two, CardSuit.Diamond).ToString()] = Resources._2_of_diamonds;
            cardImages[new Card(CardRank.Two, CardSuit.Club).ToString()] = Resources._2_of_clubs;
            cardImages[new Card(CardRank.Two, CardSuit.Spade).ToString()] = Resources._2_of_spades;
            cardImages[new Card(CardRank.Three, CardSuit.Heart).ToString()] = Resources._3_of_hearts;
            cardImages[new Card(CardRank.Three, CardSuit.Diamond).ToString()] = Resources._3_of_diamonds;
            cardImages[new Card(CardRank.Three, CardSuit.Club).ToString()] = Resources._3_of_clubs;
            cardImages[new Card(CardRank.Three, CardSuit.Spade).ToString()] = Resources._3_of_spades;
            cardImages[new Card(CardRank.Four, CardSuit.Heart).ToString()] = Resources._4_of_hearts;
            cardImages[new Card(CardRank.Four, CardSuit.Diamond).ToString()] = Resources._4_of_diamonds;
            cardImages[new Card(CardRank.Four, CardSuit.Club).ToString()] = Resources._4_of_clubs;
            cardImages[new Card(CardRank.Four, CardSuit.Spade).ToString()] = Resources._4_of_spades;
            cardImages[new Card(CardRank.Five, CardSuit.Heart).ToString()] = Resources._5_of_hearts;
            cardImages[new Card(CardRank.Five, CardSuit.Diamond).ToString()] = Resources._5_of_diamonds;
            cardImages[new Card(CardRank.Five, CardSuit.Club).ToString()] = Resources._5_of_clubs;
            cardImages[new Card(CardRank.Five, CardSuit.Spade).ToString()] = Resources._5_of_spades;
            cardImages[new Card(CardRank.Six, CardSuit.Heart).ToString()] = Resources._6_of_hearts;
            cardImages[new Card(CardRank.Six, CardSuit.Diamond).ToString()] = Resources._6_of_diamonds;
            cardImages[new Card(CardRank.Six, CardSuit.Club).ToString()] = Resources._6_of_clubs;
            cardImages[new Card(CardRank.Six, CardSuit.Spade).ToString()] = Resources._6_of_spades;
            cardImages[new Card(CardRank.Seven, CardSuit.Heart).ToString()] = Resources._7_of_hearts;
            cardImages[new Card(CardRank.Seven, CardSuit.Diamond).ToString()] = Resources._7_of_diamonds;
            cardImages[new Card(CardRank.Seven, CardSuit.Club).ToString()] = Resources._7_of_clubs;
            cardImages[new Card(CardRank.Seven, CardSuit.Spade).ToString()] = Resources._7_of_spades;
            cardImages[new Card(CardRank.Eight, CardSuit.Heart).ToString()] = Resources._8_of_hearts;
            cardImages[new Card(CardRank.Eight, CardSuit.Diamond).ToString()] = Resources._8_of_diamonds;
            cardImages[new Card(CardRank.Eight, CardSuit.Club).ToString()] = Resources._8_of_clubs;
            cardImages[new Card(CardRank.Eight, CardSuit.Spade).ToString()] = Resources._8_of_spades;
            cardImages[new Card(CardRank.Nine, CardSuit.Heart).ToString()] = Resources._9_of_hearts;
            cardImages[new Card(CardRank.Nine, CardSuit.Diamond).ToString()] = Resources._9_of_diamonds;
            cardImages[new Card(CardRank.Nine, CardSuit.Club).ToString()] = Resources._9_of_clubs;
            cardImages[new Card(CardRank.Nine, CardSuit.Spade).ToString()] = Resources._9_of_spades;
            cardImages[new Card(CardRank.Ten, CardSuit.Heart).ToString()] = Resources._10_of_hearts;
            cardImages[new Card(CardRank.Ten, CardSuit.Diamond).ToString()] = Resources._10_of_diamonds;
            cardImages[new Card(CardRank.Ten, CardSuit.Club).ToString()] = Resources._10_of_clubs;
            cardImages[new Card(CardRank.Ten, CardSuit.Spade).ToString()] = Resources._10_of_spades;
            cardImages[new Card(CardRank.Jack, CardSuit.Heart).ToString()] = Resources.jack_of_hearts;
            cardImages[new Card(CardRank.Jack, CardSuit.Diamond).ToString()] = Resources.jack_of_diamonds;
            cardImages[new Card(CardRank.Jack, CardSuit.Club).ToString()] = Resources.jack_of_clubs;
            cardImages[new Card(CardRank.Jack, CardSuit.Spade).ToString()] = Resources.jack_of_spades;
            cardImages[new Card(CardRank.Queen, CardSuit.Heart).ToString()] = Resources.queen_of_hearts;
            cardImages[new Card(CardRank.Queen, CardSuit.Diamond).ToString()] = Resources.queen_of_diamonds;
            cardImages[new Card(CardRank.Queen, CardSuit.Club).ToString()] = Resources.queen_of_clubs;
            cardImages[new Card(CardRank.Queen, CardSuit.Spade).ToString()] = Resources.queen_of_spades;
            cardImages[new Card(CardRank.King, CardSuit.Heart).ToString()] = Resources.king_of_hearts;
            cardImages[new Card(CardRank.King, CardSuit.Diamond).ToString()] = Resources.king_of_diamonds;
            cardImages[new Card(CardRank.King, CardSuit.Club).ToString()] = Resources.king_of_clubs;
            cardImages[new Card(CardRank.King, CardSuit.Spade).ToString()] = Resources.king_of_spades;
            cardImages[new Card(CardRank.Ace, CardSuit.Heart).ToString()] = Resources.ace_of_hearts;
            cardImages[new Card(CardRank.Ace, CardSuit.Diamond).ToString()] = Resources.ace_of_diamonds;
            cardImages[new Card(CardRank.Ace, CardSuit.Club).ToString()] = Resources.ace_of_clubs;
            cardImages[new Card(CardRank.Ace, CardSuit.Spade).ToString()] = Resources.ace_of_spades;
        }
        public GraphicsStore(CardSet deck, Control parent)
        {
            parent.SuspendLayout();
            foreach (var card in deck)
            {
                var pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxes[card] = pb;
                cards[pb] = card;
                parent.Controls.Add(pb);
            }
            Parent = parent;
            parent.ResumeLayout();
        }
        public PictureBox GetPictureBox(Card card, bool opened = true)
        {
            var pb = pictureBoxes[card];
            pb.Image = opened ? cardImages[$"{card}"] : FaceDownImage;
            return pb;
        }
        public Card GetCard(PictureBox pb)
        {
            return cards[pb];
        }
    }
}