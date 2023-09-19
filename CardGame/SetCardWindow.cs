using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class SetCardWindow : Form
    {
        public static SetCardWindow instance;
        public SetCardWindow()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValueTB.Text == "")
            {
                Form1.Instance.lb1.Text = "You didn't enter all the propetries. Card wasn't set";
                this.Close();
            }
            else if (SuitTB.Text == "")
            {
                Form1.Instance.lb1.Text = "You didn't enter all the propetries. Card wasn't set";
                this.Close();
            }
            else if (ColorTB.Text == "")
            {
                Form1.Instance.lb1.Text = "You didn't enter all the propetries. Card wasn't set";
                this.Close();
            }
            else
            {
                Form1.Instance.tb1.Text = SuitTB.Text;
                Form1.Instance.tb2.Text = ValueTB.Text;
                Form1.Instance.cardbase.BackColor = ColorTB.BackColor;
                if (ColorTB.BackColor == Color.Black)
                {
                    Form1.Instance.tb3.Text = "Black";
                }
                else
                {
                    Form1.Instance.tb3.Text = "Red";
                }
                Form1.Instance.lb1.Text = "Card is set. You can battle now!";
                this.Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton4.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton6.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton5.Text;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton7.Text;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton8.Text;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton9.Text;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton10.Text;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            ValueTB.Text = radioButton11.Text;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            SuitTB.Text = radioButton12.Text;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            SuitTB.Text=radioButton13.Text;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            SuitTB.Text = radioButton14.Text;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            SuitTB.Text = radioButton15.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ColorTB.Text = "Black";
            ColorTB.BackColor = Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ColorTB.Text = "Red";
            ColorTB.BackColor = Color.Red;
        }
    }
}
