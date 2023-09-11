using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardDll;

namespace CardGame
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public TextBox tb1;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            tb1 = SuitTB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCardInfo();
        }
        public void GetCardInfo() 
        {
            Card testcard = new Card();
            testcard.SetRandomCard();
            SuitTB.Text = testcard.Suit;
            ValueTB.Text = testcard.Value.ToString();
            if (testcard.Color == "Black")
            {
                CardBase.BackColor = Color.Black;
            }
            else
            {
                CardBase.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetCardWindow setCardWindow = new SetCardWindow();
            setCardWindow.Show();
        }
    }
}
