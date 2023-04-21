
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
            this.pTable = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl46 = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.pActive = new System.Windows.Forms.PictureBox();
            this.lInfo = new System.Windows.Forms.Label();
            this.bPass = new System.Windows.Forms.Button();
            this.bTake = new System.Windows.Forms.Button();
            this.pPlayer1 = new System.Windows.Forms.Panel();
            this.pPLayer2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pPlayer23 = new System.Windows.Forms.Panel();
            this.pPlayer13 = new System.Windows.Forms.Panel();
            this.pPlayer3 = new System.Windows.Forms.Panel();
            this.pPlayer6 = new System.Windows.Forms.Panel();
            this.lbl5 = new System.Windows.Forms.Label();
            this.pPlayer4 = new System.Windows.Forms.Panel();
            this.pPlayer46 = new System.Windows.Forms.Panel();
            this.pPlayer5 = new System.Windows.Forms.Panel();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.pTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pActive)).BeginInit();
            this.pPLayer2.SuspendLayout();
            this.pPlayer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDeck
            // 
            this.pDeck.Location = new System.Drawing.Point(3, 132);
            this.pDeck.Name = "pDeck";
            this.pDeck.Size = new System.Drawing.Size(144, 149);
            this.pDeck.TabIndex = 0;
            // 
            // pTable
            // 
            this.pTable.Controls.Add(this.panel3);
            this.pTable.Location = new System.Drawing.Point(196, 135);
            this.pTable.Name = "pTable";
            this.pTable.Size = new System.Drawing.Size(262, 119);
            this.pTable.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(349, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 73);
            this.panel3.TabIndex = 9;
            // 
            // lbl46
            // 
            this.lbl46.AutoSize = true;
            this.lbl46.Location = new System.Drawing.Point(750, 197);
            this.lbl46.Name = "lbl46";
            this.lbl46.Size = new System.Drawing.Size(38, 15);
            this.lbl46.TabIndex = 17;
            this.lbl46.Text = "label1";
            this.lbl46.Visible = false;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(13, 13);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 15);
            this.lStatus.TabIndex = 4;
            // 
            // pActive
            // 
            this.pActive.Location = new System.Drawing.Point(691, 140);
            this.pActive.Name = "pActive";
            this.pActive.Size = new System.Drawing.Size(97, 150);
            this.pActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pActive.TabIndex = 5;
            this.pActive.TabStop = false;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(13, 284);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(0, 15);
            this.lInfo.TabIndex = 6;
            this.lInfo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // bPass
            // 
            this.bPass.Enabled = false;
            this.bPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPass.Location = new System.Drawing.Point(599, 408);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(97, 30);
            this.bPass.TabIndex = 7;
            this.bPass.Text = "Pass";
            this.bPass.UseVisualStyleBackColor = true;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // bTake
            // 
            this.bTake.Enabled = false;
            this.bTake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTake.Location = new System.Drawing.Point(702, 408);
            this.bTake.Name = "bTake";
            this.bTake.Size = new System.Drawing.Size(97, 30);
            this.bTake.TabIndex = 8;
            this.bTake.Text = "Give Up";
            this.bTake.UseVisualStyleBackColor = true;
            this.bTake.Click += new System.EventHandler(this.bTake_Click);
            // 
            // pPlayer1
            // 
            this.pPlayer1.Location = new System.Drawing.Point(215, 304);
            this.pPlayer1.Name = "pPlayer1";
            this.pPlayer1.Size = new System.Drawing.Size(470, 100);
            this.pPlayer1.TabIndex = 1;
            // 
            // pPLayer2
            // 
            this.pPLayer2.Controls.Add(this.panel4);
            this.pPLayer2.Location = new System.Drawing.Point(214, 13);
            this.pPLayer2.Name = "pPLayer2";
            this.pPLayer2.Size = new System.Drawing.Size(470, 96);
            this.pPLayer2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 14);
            this.panel4.TabIndex = 13;
            // 
            // pPlayer23
            // 
            this.pPlayer23.Location = new System.Drawing.Point(60, 13);
            this.pPlayer23.Name = "pPlayer23";
            this.pPlayer23.Size = new System.Drawing.Size(313, 96);
            this.pPlayer23.TabIndex = 4;
            // 
            // pPlayer13
            // 
            this.pPlayer13.Location = new System.Drawing.Point(61, 304);
            this.pPlayer13.Name = "pPlayer13";
            this.pPlayer13.Size = new System.Drawing.Size(313, 100);
            this.pPlayer13.TabIndex = 5;
            // 
            // pPlayer3
            // 
            this.pPlayer3.Location = new System.Drawing.Point(438, 12);
            this.pPlayer3.Name = "pPlayer3";
            this.pPlayer3.Size = new System.Drawing.Size(313, 97);
            this.pPlayer3.TabIndex = 9;
            // 
            // pPlayer6
            // 
            this.pPlayer6.Location = new System.Drawing.Point(434, 304);
            this.pPlayer6.Name = "pPlayer6";
            this.pPlayer6.Size = new System.Drawing.Size(313, 100);
            this.pPlayer6.TabIndex = 6;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(750, 304);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(38, 15);
            this.lbl5.TabIndex = 17;
            this.lbl5.Text = "label1";
            this.lbl5.Visible = false;
            // 
            // pPlayer4
            // 
            this.pPlayer4.Location = new System.Drawing.Point(509, 157);
            this.pPlayer4.Name = "pPlayer4";
            this.pPlayer4.Size = new System.Drawing.Size(284, 86);
            this.pPlayer4.TabIndex = 9;
            // 
            // pPlayer46
            // 
            this.pPlayer46.Location = new System.Drawing.Point(480, 107);
            this.pPlayer46.Name = "pPlayer46";
            this.pPlayer46.Size = new System.Drawing.Size(313, 86);
            this.pPlayer46.TabIndex = 10;
            // 
            // pPlayer5
            // 
            this.pPlayer5.Controls.Add(this.lbl4);
            this.pPlayer5.Location = new System.Drawing.Point(480, 223);
            this.pPlayer5.Name = "pPlayer5";
            this.pPlayer5.Size = new System.Drawing.Size(313, 76);
            this.pPlayer5.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(29, 23);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(38, 15);
            this.lbl4.TabIndex = 17;
            this.lbl4.Text = "label1";
            this.lbl4.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(214, 107);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 15);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "label1";
            this.lbl2.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(214, 407);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 15);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "label2";
            this.lbl1.Visible = false;
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.Location = new System.Drawing.Point(60, 107);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(38, 15);
            this.lbl23.TabIndex = 13;
            this.lbl23.Text = "label1";
            this.lbl23.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(438, 112);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(38, 15);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "label1";
            this.lbl3.Visible = false;
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Location = new System.Drawing.Point(60, 407);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(38, 15);
            this.lbl13.TabIndex = 15;
            this.lbl13.Text = "label1";
            this.lbl13.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(438, 408);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(38, 15);
            this.lbl6.TabIndex = 16;
            this.lbl6.Text = "label1";
            this.lbl6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl46);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.lbl23);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.bPass);
            this.Controls.Add(this.bTake);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.pPlayer5);
            this.Controls.Add(this.pPlayer46);
            this.Controls.Add(this.pPlayer6);
            this.Controls.Add(this.pPlayer3);
            this.Controls.Add(this.pPlayer4);
            this.Controls.Add(this.pPlayer13);
            this.Controls.Add(this.pPlayer23);
            this.Controls.Add(this.pActive);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.pPLayer2);
            this.Controls.Add(this.pTable);
            this.Controls.Add(this.pPlayer1);
            this.Controls.Add(this.pDeck);
            this.Name = "Form1";
            this.Text = "Durak";
            this.pTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pActive)).EndInit();
            this.pPLayer2.ResumeLayout(false);
            this.pPlayer5.ResumeLayout(false);
            this.pPlayer5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDeck;
        private System.Windows.Forms.Panel pTable;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.PictureBox pActive;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.Button bPass;
        private System.Windows.Forms.Button bTake;
        private System.Windows.Forms.Panel pPlayer1;
        private System.Windows.Forms.Panel pPLayer2;
        private System.Windows.Forms.Panel pPlayer23;
        private System.Windows.Forms.Panel pPlayer13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pPlayer6;
        private System.Windows.Forms.Panel pPlayer3;
        private System.Windows.Forms.Panel pPlayer4;
        private System.Windows.Forms.Panel pPlayer46;
        private System.Windows.Forms.Panel pPlayer5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl46;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl6;
    }
}

