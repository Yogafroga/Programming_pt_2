namespace CardGame
{
    partial class CardGame_form
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
            this.SuitCard1 = new System.Windows.Forms.Label();
            this.RankCard1 = new System.Windows.Forms.Label();
            this.CardBase1 = new System.Windows.Forms.Panel();
            this.SuitCard2 = new System.Windows.Forms.Label();
            this.CardBase2 = new System.Windows.Forms.Panel();
            this.RankCard2 = new System.Windows.Forms.Label();
            this.randcard1 = new System.Windows.Forms.Button();
            this.customcard1 = new System.Windows.Forms.Button();
            this.randcard2 = new System.Windows.Forms.Button();
            this.customcard2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Suits1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ranks1 = new System.Windows.Forms.ListBox();
            this.Ranks2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Suits2 = new System.Windows.Forms.ListBox();
            this.fightbutton = new System.Windows.Forms.Button();
            this.resultlabel = new System.Windows.Forms.Label();
            this.CardBase1.SuspendLayout();
            this.CardBase2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuitCard1
            // 
            this.SuitCard1.AutoSize = true;
            this.SuitCard1.Location = new System.Drawing.Point(14, 28);
            this.SuitCard1.Name = "SuitCard1";
            this.SuitCard1.Size = new System.Drawing.Size(60, 20);
            this.SuitCard1.TabIndex = 0;
            this.SuitCard1.Text = "Not set";
            // 
            // RankCard1
            // 
            this.RankCard1.AutoSize = true;
            this.RankCard1.Location = new System.Drawing.Point(164, 277);
            this.RankCard1.Name = "RankCard1";
            this.RankCard1.Size = new System.Drawing.Size(60, 20);
            this.RankCard1.TabIndex = 1;
            this.RankCard1.Text = "Not set";
            // 
            // CardBase1
            // 
            this.CardBase1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CardBase1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CardBase1.Controls.Add(this.RankCard1);
            this.CardBase1.Controls.Add(this.SuitCard1);
            this.CardBase1.Location = new System.Drawing.Point(221, 145);
            this.CardBase1.Name = "CardBase1";
            this.CardBase1.Size = new System.Drawing.Size(233, 319);
            this.CardBase1.TabIndex = 2;
            // 
            // SuitCard2
            // 
            this.SuitCard2.AutoSize = true;
            this.SuitCard2.Location = new System.Drawing.Point(14, 28);
            this.SuitCard2.Name = "SuitCard2";
            this.SuitCard2.Size = new System.Drawing.Size(60, 20);
            this.SuitCard2.TabIndex = 0;
            this.SuitCard2.Text = "Not set";
            // 
            // CardBase2
            // 
            this.CardBase2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CardBase2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CardBase2.Controls.Add(this.RankCard2);
            this.CardBase2.Controls.Add(this.SuitCard2);
            this.CardBase2.Location = new System.Drawing.Point(538, 145);
            this.CardBase2.Name = "CardBase2";
            this.CardBase2.Size = new System.Drawing.Size(233, 319);
            this.CardBase2.TabIndex = 3;
            // 
            // RankCard2
            // 
            this.RankCard2.AutoSize = true;
            this.RankCard2.Location = new System.Drawing.Point(164, 277);
            this.RankCard2.Name = "RankCard2";
            this.RankCard2.Size = new System.Drawing.Size(60, 20);
            this.RankCard2.TabIndex = 1;
            this.RankCard2.Text = "Not set";
            // 
            // randcard1
            // 
            this.randcard1.Location = new System.Drawing.Point(34, 145);
            this.randcard1.Name = "randcard1";
            this.randcard1.Size = new System.Drawing.Size(162, 54);
            this.randcard1.TabIndex = 4;
            this.randcard1.Text = "Set random card";
            this.randcard1.UseVisualStyleBackColor = true;
            this.randcard1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customcard1
            // 
            this.customcard1.Location = new System.Drawing.Point(34, 483);
            this.customcard1.Name = "customcard1";
            this.customcard1.Size = new System.Drawing.Size(162, 54);
            this.customcard1.TabIndex = 5;
            this.customcard1.Text = "Set custom card";
            this.customcard1.UseVisualStyleBackColor = true;
            this.customcard1.Click += new System.EventHandler(this.customcard1_Click);
            // 
            // randcard2
            // 
            this.randcard2.Location = new System.Drawing.Point(800, 145);
            this.randcard2.Name = "randcard2";
            this.randcard2.Size = new System.Drawing.Size(162, 54);
            this.randcard2.TabIndex = 4;
            this.randcard2.Text = "Set random card";
            this.randcard2.UseVisualStyleBackColor = true;
            this.randcard2.Click += new System.EventHandler(this.randcard2_Click);
            // 
            // customcard2
            // 
            this.customcard2.Location = new System.Drawing.Point(800, 483);
            this.customcard2.Name = "customcard2";
            this.customcard2.Size = new System.Drawing.Size(162, 54);
            this.customcard2.TabIndex = 5;
            this.customcard2.Text = "Set custom card";
            this.customcard2.UseVisualStyleBackColor = true;
            this.customcard2.Click += new System.EventHandler(this.customcard2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(395, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Card Game";
            // 
            // Suits1
            // 
            this.Suits1.FormattingEnabled = true;
            this.Suits1.ItemHeight = 20;
            this.Suits1.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.Suits1.Location = new System.Drawing.Point(34, 281);
            this.Suits1.Name = "Suits1";
            this.Suits1.Size = new System.Drawing.Size(135, 24);
            this.Suits1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Suit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rank:";
            // 
            // Ranks1
            // 
            this.Ranks1.FormattingEnabled = true;
            this.Ranks1.ItemHeight = 20;
            this.Ranks1.Items.AddRange(new object[] {
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.Ranks1.Location = new System.Drawing.Point(34, 398);
            this.Ranks1.Name = "Ranks1";
            this.Ranks1.Size = new System.Drawing.Size(135, 24);
            this.Ranks1.TabIndex = 10;
            // 
            // Ranks2
            // 
            this.Ranks2.FormattingEnabled = true;
            this.Ranks2.ItemHeight = 20;
            this.Ranks2.Items.AddRange(new object[] {
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King",
            "Ace"});
            this.Ranks2.Location = new System.Drawing.Point(827, 398);
            this.Ranks2.Name = "Ranks2";
            this.Ranks2.Size = new System.Drawing.Size(135, 24);
            this.Ranks2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(880, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rank:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Suit:";
            // 
            // Suits2
            // 
            this.Suits2.FormattingEnabled = true;
            this.Suits2.ItemHeight = 20;
            this.Suits2.Items.AddRange(new object[] {
            "Hearts",
            "Clubs",
            "Diamonds",
            "Spades"});
            this.Suits2.Location = new System.Drawing.Point(827, 281);
            this.Suits2.Name = "Suits2";
            this.Suits2.Size = new System.Drawing.Size(135, 24);
            this.Suits2.TabIndex = 11;
            // 
            // fightbutton
            // 
            this.fightbutton.Location = new System.Drawing.Point(306, 511);
            this.fightbutton.Name = "fightbutton";
            this.fightbutton.Size = new System.Drawing.Size(173, 49);
            this.fightbutton.TabIndex = 15;
            this.fightbutton.Text = "Fight!";
            this.fightbutton.UseVisualStyleBackColor = true;
            this.fightbutton.Click += new System.EventHandler(this.fightbutton_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Location = new System.Drawing.Point(534, 525);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(98, 20);
            this.resultlabel.TabIndex = 16;
            this.resultlabel.Text = "No battle yet";
            // 
            // CardGame_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 585);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.fightbutton);
            this.Controls.Add(this.Ranks2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Suits2);
            this.Controls.Add(this.Ranks1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Suits1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customcard2);
            this.Controls.Add(this.customcard1);
            this.Controls.Add(this.randcard2);
            this.Controls.Add(this.randcard1);
            this.Controls.Add(this.CardBase2);
            this.Controls.Add(this.CardBase1);
            this.Name = "CardGame_form";
            this.Text = "CardGame_form";
            this.CardBase1.ResumeLayout(false);
            this.CardBase1.PerformLayout();
            this.CardBase2.ResumeLayout(false);
            this.CardBase2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuitCard1;
        private System.Windows.Forms.Label RankCard1;
        private System.Windows.Forms.Panel CardBase1;
        private System.Windows.Forms.Label SuitCard2;
        private System.Windows.Forms.Panel CardBase2;
        private System.Windows.Forms.Button randcard1;
        private System.Windows.Forms.Button customcard1;
        private System.Windows.Forms.Button randcard2;
        private System.Windows.Forms.Button customcard2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RankCard2;
        private System.Windows.Forms.ListBox Suits1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Ranks1;
        private System.Windows.Forms.ListBox Ranks2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Suits2;
        private System.Windows.Forms.Button fightbutton;
        private System.Windows.Forms.Label resultlabel;
    }
}