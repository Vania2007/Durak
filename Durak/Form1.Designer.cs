
namespace Durak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pDeck = new System.Windows.Forms.Panel();
            this.pPlayer1 = new System.Windows.Forms.Panel();
            this.pTable = new System.Windows.Forms.Panel();
            this.pPLayer2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pDeck
            // 
            this.pDeck.Location = new System.Drawing.Point(12, 130);
            this.pDeck.Name = "pDeck";
            this.pDeck.Size = new System.Drawing.Size(123, 160);
            this.pDeck.TabIndex = 0;
            // 
            // pPlayer1
            // 
            this.pPlayer1.Location = new System.Drawing.Point(214, 338);
            this.pPlayer1.Name = "pPlayer1";
            this.pPlayer1.Size = new System.Drawing.Size(470, 100);
            this.pPlayer1.TabIndex = 1;
            // 
            // pTable
            // 
            this.pTable.Location = new System.Drawing.Point(214, 140);
            this.pTable.Name = "pTable";
            this.pTable.Size = new System.Drawing.Size(470, 150);
            this.pTable.TabIndex = 2;
            // 
            // pPLayer2
            // 
            this.pPLayer2.Location = new System.Drawing.Point(214, 13);
            this.pPLayer2.Name = "pPLayer2";
            this.pPLayer2.Size = new System.Drawing.Size(470, 96);
            this.pPLayer2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pPLayer2);
            this.Controls.Add(this.pTable);
            this.Controls.Add(this.pPlayer1);
            this.Controls.Add(this.pDeck);
            this.Name = "Form1";
            this.Text = "Durak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDeck;
        private System.Windows.Forms.Panel pPlayer1;
        private System.Windows.Forms.Panel pTable;
        private System.Windows.Forms.Panel pPLayer2;
    }
}

