using CardLib;
using GraphicsInfrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak
{
    public partial class Form1 : Form
    {
        DurakLogic game;
        List<GraphicsCardSet> sets = new List<GraphicsCardSet>();
        Card activeCard;
        GraphicsCardSet table;
        GraphicsStore store;
        public Form1()
        {
            InitializeComponent();
            pActive.BringToFront();
            game = new DurakLogic(players, ShowInfo, ShowState); 
            store = new GraphicsStore(game.Deck, this);
            table = new GraphicsCardSet(game.Table, new Rectangle(pTable.Location, pTable.Size),
                store);
            sets.Add(new GraphicsCardSet(game.Deck, new Rectangle(pDeck.Location, pDeck.Size),
                store));
            sets.Add(new GraphicsCardSet(game.Players[0].Hand, new Rectangle(pPlayer1.Location, pPlayer1.Size),
                store));
            sets.Add(new GraphicsCardSet(game.Players[1].Hand, new Rectangle(pPLayer2.Location, pPLayer2.Size),
                store));
            sets.Add(table);
            BindEvents();
            game.Start();
            Update();
        }

        //Додати кнопки «Пас» і «Забрати», активність яких визначається у ментоді ShowState на основі режуму гри
        //Додати на форму 4—6 гравців
        //Повернути всі малюнки у cardStore          +
        //Протестувати програму на предмет помилок
        //Додати мітки для імен гравців

        private void ShowInfo(string message)
        {
            lInfo.Text = message;
        }

        List<Player> players = new List<Player>()
        {
            new Player("Bob"),
            new Player("Patric")
        };
        private void DistributionOfPlayersOnTheTable()
        {

        }
        private void ShowState()
        {
            foreach (var set in sets)
            {
                if(set.CardSet == game.Deck)
                {
                    set.Draw(c => c == game.Trump);
                }
                else
                set.Draw(game.Current.Hand == set.CardSet || game.Table == set.CardSet);
            }
        }

        private void BindEvents()
        {
            foreach (var card in game.Deck)
            {
                var pb = store.GetPictureBox(card);
                pb.MouseDown += SelectCard;
                pb.MouseMove += CardMoving;
                pb.MouseUp += Turn;
            }
        }
        private void Turn(object sender, MouseEventArgs e)
        {
            if (activeCard == null) return;
            if (e.Button != MouseButtons.Left) return;
            Rectangle r1 = new Rectangle(pActive.Location, pActive.Size);
            Rectangle r2 = table.Frame;
            if (r1.IntersectsWith(r2))
                game.Turn(activeCard);
            activeCard = null;
            pActive.Hide();
        }
        private void CardMoving(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (activeCard == null) return;
            pActive.Location = new Point(Cursor.Position.X - this.Location.X - pActive.Width,
                Cursor.Position.Y - this.Location.Y - pActive.Height);
        }
        private void SelectCard(object sender, MouseEventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            pb.BringToFront();
            activeCard = store.GetCard(pb);
            pActive.Location = new Point(Cursor.Position.X - this.Location.X - pActive.Width,
                Cursor.Position.Y - this.Location.Y - pActive.Height);
            pActive.Image = pb.Image;
            pActive.Show();
        }
        
    }
}
