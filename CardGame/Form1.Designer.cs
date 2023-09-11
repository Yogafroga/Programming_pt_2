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
            this.SuitTB = new System.Windows.Forms.TextBox();
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CardBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Random Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardBase
            // 
            this.CardBase.Controls.Add(this.SuitTB);
            this.CardBase.Controls.Add(this.ValueTB);
            this.CardBase.Location = new System.Drawing.Point(491, 52);
            this.CardBase.Name = "CardBase";
            this.CardBase.Size = new System.Drawing.Size(258, 333);
            this.CardBase.TabIndex = 1;
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
            this.button2.Location = new System.Drawing.Point(28, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Set Card";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CardBase);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CardBase.ResumeLayout(false);
            this.CardBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel CardBase;
        private System.Windows.Forms.TextBox SuitTB;
        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.Button button2;
    }
}

