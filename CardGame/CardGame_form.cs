using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_for_Cards;

namespace CardGame
{
    public partial class CardGame_form : Form
    {
        private const string C = @"\clubs.png";
        private const string H = @"\hearts.png";
        private const string D = @"\diamonds.png";
        private const string S = @"\spades.png";
        const Suit trump = Suit.Hearts;
        Card card1 = new Card();
        Card card2 = new Card();
        public CardGame_form()
        {
            InitializeComponent();
        }
        public void FillUI(Label label1, Label label2, Panel panel, Card card)
        {
            label1.Text = card.Suit.ToString();
            label2.Text = card.Rank.ToString();

            switch (card.Suit) // оператор выбора, определяющий изображение масти и цвета карты на форме
            {
                case Suit.Hearts:
                    panel.BackgroundImage = Image.FromFile
           (System.Environment.GetFolderPath
           (System.Environment.SpecialFolder.Personal)
           + H);
                    break;

                case Suit.Spades:
                    panel.BackgroundImage = Image.FromFile
           (System.Environment.GetFolderPath
           (System.Environment.SpecialFolder.Personal)
           + S);
                    break;

                case Suit.Diamonds:
                    panel.BackgroundImage = Image.FromFile
           (System.Environment.GetFolderPath
           (System.Environment.SpecialFolder.Personal)
           + D);
                    break;

                case Suit.Clubs:
                    panel.BackgroundImage = Image.FromFile
           (System.Environment.GetFolderPath
           (System.Environment.SpecialFolder.Personal)
           + C);
                    break;
            }

        }
        public Card SettingCard(ListBox listBox1, ListBox listbox2, Card card)
        {
            // Блок с выбором масти карты
            switch (listBox1.SelectedItem)
            {
                case "Hearts":
                    card.SetSuit(Suit.Hearts);
                    break;
                case "Spades":
                    card.SetSuit(Suit.Spades);
                    break;
                case "Diamonds":
                    card.SetSuit(Suit.Diamonds);
                    break;
                case "Clubs":
                    card.SetSuit(Suit.Clubs);
                    break;
            }
            // Блок с выбором ранга
            switch (listbox2.SelectedItem)
            {
                case "Six":
                    card.SetRank(Rank.Six);
                    break;
                case "Seven":
                    card.SetRank(Rank.Seven);
                    break;
                case "Eight":
                    card.SetRank(Rank.Eight);
                    break;
                case "Nine":
                    card.SetRank(Rank.Nine);
                    break;
                case "Ten":
                    card.SetRank(Rank.Ten);
                    break;
                case "Jack":
                    card.SetRank(Rank.Jack);
                    break;
                case "Queen":
                    card.SetRank(Rank.Queen);
                    break;
                case "King":
                    card.SetRank(Rank.King);
                    break;
                case "Ace":
                    card.SetRank(Rank.Ace);
                    break;
            }
            return card;
        }

        private bool FirstCardBeatsSecond(Card card1, Card card2)
        {
            if (card1.Suit == card2.Suit)
            {
                switch (card1.Rank)
                {
                    case Rank.Six:
                        return false;
                    case Rank.Seven:
                        return card2.Rank < Rank.Seven;
                    case Rank.Eight:
                        return card2.Rank < Rank.Eight;
                    case Rank.Nine:
                        return card2.Rank < Rank.Nine;
                    case Rank.Ten:
                        return card2.Rank < Rank.Ten;
                    case Rank.Jack:
                        return card2.Rank < Rank.Jack;
                    case Rank.Queen:
                        return card2.Rank < Rank.Queen;
                    case Rank.King:
                        return card2.Rank < Rank.King;
                    case Rank.Ace:
                        return true;
                }
            }
            else
                if(card1.Suit == trump)
                {
                    return true;
                }
                return false;

        }
        // Блок с кнопками

        private void button1_Click(object sender, EventArgs e)
        {
            card1.SetRandomCard();
            FillUI(SuitCard1, RankCard1, CardBase1, card1);

        }

        private void randcard2_Click(object sender, EventArgs e)
        {
            card2.SetRandomCard();
            FillUI(SuitCard2, RankCard2, CardBase2, card2);

        }

        private void customcard1_Click(object sender, EventArgs e)
        {
            card1 = SettingCard(Suits1, Ranks1, card1);
            FillUI(SuitCard1, RankCard1, CardBase1, card1);
        }

        private void customcard2_Click(object sender, EventArgs e)
        {
            card2 = SettingCard(Suits2, Ranks2, card2);
            FillUI(SuitCard2, RankCard2 , CardBase2, card2);
        }

        private void fightbutton_Click(object sender, EventArgs e)
        {
            if (SuitCard1.Text == "Not set" || SuitCard2.Text == "Not set")
            {
                resultlabel.Text = "Set both cards first!!!";
                return;
            }
            bool result = FirstCardBeatsSecond(card1, card2);
            resultlabel.Text = result ? "First card won!!!" : "First card can't beat the second!!!";

        }
    }
}
