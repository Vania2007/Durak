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
        Form1 GlobalForm;
        public Form2()
        {
            InitializeComponent();
        }
        public void CountOfTextBoxes()
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                TextBox tb = new TextBox();
                tb.Location = new Point(numericUpDown1.Location.X, numericUpDown1.Location.Y+numericUpDown1.Height+10);
                tb.Size = new Size(120, 30);
                this.Controls.Add(tb);
            }
        }
    }
}
