using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using CardDll;

namespace CardGame
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public TextBox tb1;
        public TextBox tb2;
        public Label lb1;
        public TextBox tb3;
        public Panel cardbase;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            tb1 = SuitTB;
            tb2 = ValueTB;
            lb1 = FeedBack;
            tb3 = ColorTB;
            cardbase = CardBase;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandCard();
        }
        public void RandCard() 
        {
            Card testcard = new Card();
            testcard.SetRandomCard();
            SuitTB.Text = testcard.Suit;
            ValueTB.Text = testcard.Value.ToString();
            if (testcard.Color == "Black")
            {
                CardBase.BackColor = Color.Black;
                ColorTB.Text = "Black";
            }
            else
            {
                CardBase.BackColor = Color.Red;
                ColorTB.Text = "Red";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetCardWindow setCardWindow = new SetCardWindow();
            setCardWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetTheRule(SuitTB.Text, ValueTB.Text, ColorTB.Text);
        }

        public void GetTheRule(string suit, string value, string color)
        {
            if (suit == "")
            {
                FeedBack.Text = "Set the card first";
            }
            Card current_card = new Card(suit, value, color);
            RuleTB.Text = current_card.Rules();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TurnTB.Text = Taking_Turns(SuitTB.Text, ValueTB.Text, ColorTB.Text);
        }

        public string Taking_Turns(string suit, string value, string color)
        {
            if (suit == "")
            {
                FeedBack.Text = "Set the card first";
                return "No one";
            }
            Card random_card = new Card();
            Card ent_card = new Card(suit, value, color);
            random_card.SetRandomCard();
            bool turn_result = ent_card.Turn(random_card);
            if (turn_result) 
            {
                return "Your card";
            }
            else
            {
                return "Random card";
            }
        }
    }
}
