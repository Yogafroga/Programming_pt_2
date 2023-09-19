namespace CardGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.CardBase = new System.Windows.Forms.Panel();
            this.ColorTB = new System.Windows.Forms.TextBox();
            this.SuitTB = new System.Windows.Forms.TextBox();
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RuleTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TurnTB = new System.Windows.Forms.TextBox();
            this.FeedBack = new System.Windows.Forms.Label();
            this.CardBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Randomize First Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardBase
            // 
            this.CardBase.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CardBase.Controls.Add(this.ColorTB);
            this.CardBase.Controls.Add(this.SuitTB);
            this.CardBase.Controls.Add(this.ValueTB);
            this.CardBase.Location = new System.Drawing.Point(437, 52);
            this.CardBase.Name = "CardBase";
            this.CardBase.Size = new System.Drawing.Size(258, 333);
            this.CardBase.TabIndex = 1;
            // 
            // ColorTB
            // 
            this.ColorTB.Location = new System.Drawing.Point(127, 279);
            this.ColorTB.Name = "ColorTB";
            this.ColorTB.Size = new System.Drawing.Size(100, 26);
            this.ColorTB.TabIndex = 2;
            // 
            // SuitTB
            // 
            this.SuitTB.Location = new System.Drawing.Point(14, 15);
            this.SuitTB.Name = "SuitTB";
            this.SuitTB.Size = new System.Drawing.Size(114, 26);
            this.SuitTB.TabIndex = 1;
            // 
            // ValueTB
            // 
            this.ValueTB.Location = new System.Drawing.Point(74, 146);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(114, 26);
            this.ValueTB.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Set First Card";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(783, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show the rules";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "This card can beat any card of this suit: ";
            // 
            // RuleTB
            // 
            this.RuleTB.Location = new System.Drawing.Point(663, 414);
            this.RuleTB.Name = "RuleTB";
            this.RuleTB.Size = new System.Drawing.Size(78, 26);
            this.RuleTB.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(455, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 63);
            this.button4.TabIndex = 9;
            this.button4.Text = "Take Turns!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "wins!";
            // 
            // TurnTB
            // 
            this.TurnTB.Location = new System.Drawing.Point(602, 501);
            this.TurnTB.Name = "TurnTB";
            this.TurnTB.Size = new System.Drawing.Size(124, 26);
            this.TurnTB.TabIndex = 11;
            // 
            // FeedBack
            // 
            this.FeedBack.AutoSize = true;
            this.FeedBack.Location = new System.Drawing.Point(748, 198);
            this.FeedBack.Name = "FeedBack";
            this.FeedBack.Size = new System.Drawing.Size(470, 20);
            this.FeedBack.TabIndex = 12;
            this.FeedBack.Text = "Hello! You can randomize the card or set its properties by yourself";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 580);
            this.Controls.Add(this.FeedBack);
            this.Controls.Add(this.TurnTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RuleTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CardBase);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CardBase.ResumeLayout(false);
            this.CardBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel CardBase;
        private System.Windows.Forms.TextBox SuitTB;
        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RuleTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TurnTB;
        private System.Windows.Forms.TextBox ColorTB;
        private System.Windows.Forms.Label FeedBack;
    }
}

