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
            //if(numericUpDown1.Value == 2)
            //{
            //    TextBoxes[0].Enabled = TextBoxes[1].Enabled = true;
            //    TextBoxes[2].Enabled = TextBoxes[3].Enabled = TextBoxes[4].Enabled = TextBoxes[5].Enabled = false;
            //    TextBoxes[0].Visible = TextBoxes[1].Visible = true;
            //    TextBoxes[2].Visible = TextBoxes[3].Visible = TextBoxes[4].Visible = TextBoxes[5].Visible = false;
            //    Labels[0].Visible = Labels[1].Visible = true;
            //    Labels[2].Visible = Labels[3].Visible = Labels[4].Visible = Labels[5].Visible = false;
            //}
            CountOfTextBoxes();
            AddNameOfPlayers();
            Update();
        }
    }
}
