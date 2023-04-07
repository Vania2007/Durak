
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
            this.lStatus = new System.Windows.Forms.Label();
            this.pActive = new System.Windows.Forms.PictureBox();
            this.lInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pActive)).BeginInit();
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
            this.pActive.TabIndex = 5;
            this.pActive.TabStop = false;
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Location = new System.Drawing.Point(12, 338);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(0, 15);
            this.lInfo.TabIndex = 6;
            this.lInfo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.pActive);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.pPLayer2);
            this.Controls.Add(this.pTable);
            this.Controls.Add(this.pPlayer1);
            this.Controls.Add(this.pDeck);
            this.Name = "Form1";
            this.Text = "Durak";
            ((System.ComponentModel.ISupportInitialize)(this.pActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDeck;
        private System.Windows.Forms.Panel pPlayer1;
        private System.Windows.Forms.Panel pTable;
        private System.Windows.Forms.Panel pPLayer2;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.PictureBox pActive;
        private System.Windows.Forms.Label lInfo;
    }
}

