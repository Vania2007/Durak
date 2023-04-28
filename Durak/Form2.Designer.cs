
namespace Durak
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblCountOfPlayers = new System.Windows.Forms.Label();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.tbName3 = new System.Windows.Forms.TextBox();
            this.tbName4 = new System.Windows.Forms.TextBox();
            this.tbName5 = new System.Windows.Forms.TextBox();
            this.tbName6 = new System.Windows.Forms.TextBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.lblName4 = new System.Windows.Forms.Label();
            this.lblName5 = new System.Windows.Forms.Label();
            this.lblName6 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("a_AlgeriusCmFtz1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(331, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Durak Game";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(223, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblCountOfPlayers
            // 
            this.lblCountOfPlayers.AutoSize = true;
            this.lblCountOfPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountOfPlayers.Location = new System.Drawing.Point(12, 115);
            this.lblCountOfPlayers.Name = "lblCountOfPlayers";
            this.lblCountOfPlayers.Size = new System.Drawing.Size(169, 21);
            this.lblCountOfPlayers.TabIndex = 2;
            this.lblCountOfPlayers.Text = "The number of players:";
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(223, 190);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(120, 23);
            this.tbName1.TabIndex = 3;
            this.tbName1.Visible = false;
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(223, 221);
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(120, 23);
            this.tbName2.TabIndex = 4;
            this.tbName2.Visible = false;
            // 
            // tbName3
            // 
            this.tbName3.Location = new System.Drawing.Point(223, 250);
            this.tbName3.Name = "tbName3";
            this.tbName3.Size = new System.Drawing.Size(120, 23);
            this.tbName3.TabIndex = 5;
            this.tbName3.Visible = false;
            // 
            // tbName4
            // 
            this.tbName4.Location = new System.Drawing.Point(223, 279);
            this.tbName4.Name = "tbName4";
            this.tbName4.Size = new System.Drawing.Size(120, 23);
            this.tbName4.TabIndex = 6;
            this.tbName4.Visible = false;
            // 
            // tbName5
            // 
            this.tbName5.Location = new System.Drawing.Point(223, 308);
            this.tbName5.Name = "tbName5";
            this.tbName5.Size = new System.Drawing.Size(120, 23);
            this.tbName5.TabIndex = 7;
            this.tbName5.Visible = false;
            // 
            // tbName6
            // 
            this.tbName6.Location = new System.Drawing.Point(223, 337);
            this.tbName6.Name = "tbName6";
            this.tbName6.Size = new System.Drawing.Size(120, 23);
            this.tbName6.TabIndex = 8;
            this.tbName6.Visible = false;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName1.Location = new System.Drawing.Point(94, 188);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(123, 21);
            this.lblName1.TabIndex = 9;
            this.lblName1.Text = "1 player\'s name:";
            this.lblName1.Visible = false;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName2.Location = new System.Drawing.Point(94, 219);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(123, 21);
            this.lblName2.TabIndex = 10;
            this.lblName2.Text = "2 player\'s name:";
            this.lblName2.Visible = false;
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName3.Location = new System.Drawing.Point(94, 248);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(123, 21);
            this.lblName3.TabIndex = 11;
            this.lblName3.Text = "3 player\'s name:";
            this.lblName3.Visible = false;
            // 
            // lblName4
            // 
            this.lblName4.AutoSize = true;
            this.lblName4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName4.Location = new System.Drawing.Point(94, 277);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(123, 21);
            this.lblName4.TabIndex = 12;
            this.lblName4.Text = "4 player\'s name:";
            this.lblName4.Visible = false;
            // 
            // lblName5
            // 
            this.lblName5.AutoSize = true;
            this.lblName5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName5.Location = new System.Drawing.Point(94, 306);
            this.lblName5.Name = "lblName5";
            this.lblName5.Size = new System.Drawing.Size(123, 21);
            this.lblName5.TabIndex = 13;
            this.lblName5.Text = "5 player\'s name:";
            this.lblName5.Visible = false;
            // 
            // lblName6
            // 
            this.lblName6.AutoSize = true;
            this.lblName6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName6.Location = new System.Drawing.Point(94, 335);
            this.lblName6.Name = "lblName6";
            this.lblName6.Size = new System.Drawing.Size(123, 21);
            this.lblName6.TabIndex = 14;
            this.lblName6.Text = "6 player\'s name:";
            this.lblName6.Visible = false;
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bStart.Location = new System.Drawing.Point(261, 366);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(82, 35);
            this.bStart.TabIndex = 15;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 403);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lblName6);
            this.Controls.Add(this.lblName5);
            this.Controls.Add(this.lblName4);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.tbName6);
            this.Controls.Add(this.tbName5);
            this.Controls.Add(this.tbName4);
            this.Controls.Add(this.tbName3);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.tbName1);
            this.Controls.Add(this.lblCountOfPlayers);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form2";
            this.Text = "Durak";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCountOfPlayers;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.TextBox tbName3;
        private System.Windows.Forms.TextBox tbName4;
        private System.Windows.Forms.TextBox tbName5;
        private System.Windows.Forms.TextBox tbName6;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Label lblName4;
        private System.Windows.Forms.Label lblName5;
        private System.Windows.Forms.Label lblName6;
        private System.Windows.Forms.Button bStart;
    }
}