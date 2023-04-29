using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Durak
{
    public partial class Form2 : Form
    {
        public List<Player> Players { get; set; }
        private List<TextBox> TextBoxes { get; set; }
        private List<Label> Labels { get; set; }
        public Form2()
        {
            InitializeComponent();
            CountOfTextBoxes();
            AddNameOfPlayers();
        }
        public void CountOfTextBoxes()
        {
            List<TextBox> textBoxes = new List<TextBox>()
            {
                tbName1,
                tbName2,
                tbName3,
                tbName4,
                tbName5,
                tbName6
            };
            TextBoxes = textBoxes;
            List<Label> lblNames = new List<Label>()
            {
                lblName1,
                lblName2,
                lblName3,
                lblName4,
                lblName5,
                lblName6
            };
            Labels = lblNames;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                textBoxes[i].Enabled = true;
                textBoxes[i].Visible = true;
                lblNames[i].Visible = true;
            }
        }
        public void AddNameOfPlayers()
        {
            List<Player> players = new List<Player>();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                players.Add(new Player($"{TextBoxes[i].Text}"));
            }
            Players = players;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            AddNameOfPlayers();
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CountOfTextBoxes();
            AddNameOfPlayers();
            Update();
        }
    }
}
