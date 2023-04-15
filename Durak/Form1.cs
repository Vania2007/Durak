﻿using CardLib;
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
            DistributionOfPlayersOnTheTable();
            sets.Add(table);
            BindEvents();
            //PlacementOfLabel();
            game.Start();
            Update();
        }

        //Додати кнопки «Пас» і «Забрати», активність яких визначається у ментоді ShowState на основі режуму гри     +/-
        //Додати на форму 4—6 гравців                                                                                 +
        //Повернути всі малюнки у cardStore                                                                           +
        //Додати мітки для імен гравців                                                                              +/-
        //Протестувати програму на предмет помилок:
        //                                             1) Pass(): немає ніякої реакції
        //                                             2) Після натиску кнопок не стають недоступними, хоча цей момент прописано

        private void ShowInfo(string message)
        {
            lInfo.Text = message;
        }
        private List<Label> PlacementOfLabel()
        {
            List<Label> labels = new List<Label>();
            for (int i = 0; i < players.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{players[i].Name}";
                label.Location = new Point(); //Прив'язатися до панелей гравців: Point(panel.Location.X, panel.Location.Y-panel.Height)
                Controls.Add(label);
                labels.Add(label);
            }
            return labels;
        }
        List<Player> players = new List<Player>()
        {
            new Player("Bob"),
            new Player("Patric"),
            //new Player("Alex"),
            //new Player("Ivan"),
            //new Player("Gena"),
            //new Player("Kolya")
        };
        
        private void DistributionOfPlayersOnTheTable()
        {
            int NumberOfPlayers = players.Count;
            if (NumberOfPlayers == 2)
            {
                sets.Add(new GraphicsCardSet(game.Players[0].Hand, new Rectangle(pPlayer1.Location, pPlayer1.Size),
                store));
                sets.Add(new GraphicsCardSet(game.Players[1].Hand, new Rectangle(pPLayer2.Location, pPLayer2.Size),
                    store));
            }
            else if (NumberOfPlayers == 3)
            {
                sets.Add(new GraphicsCardSet(game.Players[0].Hand, new Rectangle(pPlayer1.Location, pPlayer1.Size),
                store));
                sets.Add(new GraphicsCardSet(game.Players[1].Hand, new Rectangle(pPlayer23.Location, pPlayer23.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[2].Hand, new Rectangle(pPlayer3.Location, pPlayer3.Size),
                    store));
            }
            else if (NumberOfPlayers == 4)
            {
                sets.Add(new GraphicsCardSet(game.Players[0].Hand, new Rectangle(pPlayer13.Location, pPlayer13.Size),
                store));
                sets.Add(new GraphicsCardSet(game.Players[1].Hand, new Rectangle(pPlayer23.Location, pPlayer23.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[2].Hand, new Rectangle(pPlayer3.Location, pPlayer3.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[3].Hand, new Rectangle(pPlayer6.Location, pPlayer6.Size),
                    store));
            }
            else if (NumberOfPlayers == 5)
            {
                sets.Add(new GraphicsCardSet(game.Players[0].Hand, new Rectangle(pPlayer13.Location, pPlayer13.Size),
                store));
                sets.Add(new GraphicsCardSet(game.Players[1].Hand, new Rectangle(pPlayer23.Location, pPlayer23.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[2].Hand, new Rectangle(pPlayer3.Location, pPlayer3.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[3].Hand, new Rectangle(pPlayer4.Location, pPlayer4.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[4].Hand, new Rectangle(pPlayer6.Location, pPlayer6.Size),
                    store));
            }
            else if (NumberOfPlayers == 6)
            {
                sets.Add(new GraphicsCardSet(game.Players[0].Hand, new Rectangle(pPlayer13.Location, pPlayer13.Size),
                store));
                sets.Add(new GraphicsCardSet(game.Players[1].Hand, new Rectangle(pPlayer23.Location, pPlayer23.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[2].Hand, new Rectangle(pPlayer3.Location, pPlayer3.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[3].Hand, new Rectangle(pPlayer46.Location, pPlayer46.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[4].Hand, new Rectangle(pPlayer5.Location, pPlayer5.Size),
                    store));
                sets.Add(new GraphicsCardSet(game.Players[5].Hand, new Rectangle(pPlayer6.Location, pPlayer6.Size),
                    store));
            }
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
            bTake.Enabled = game.Current == game.Attacker;
            bPass.Enabled = game.Current == game.Defender;
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
        
        private void bPass_Click(object sender, EventArgs e)
        {
            bPass.Enabled = false;
            game.Pass();
            bTake.Enabled = game.Current == game.Attacker;
            bPass.Enabled = game.Current == game.Defender;

        }

        private void bTake_Click(object sender, EventArgs e)
        {
            bTake.Enabled = false;
            //game.PickUp();
            game.GiveUp(); //
            bTake.Enabled = game.Current == game.Attacker;
            bPass.Enabled = game.Current == game.Defender;
        }
    }
}
