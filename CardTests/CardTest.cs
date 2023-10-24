using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame;
using System;
using DLL_for_Cards;

namespace CardTests
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ColorTest()
        {
            // source data
            CardColor expectedcolor = CardColor.Red;
            // Getting the result
            Card testcard = new Card(Suit.Hearts, Rank.Jack);
            // Comparing
            Assert.AreEqual(expectedcolor, testcard.Color);
        }

        [TestMethod]
        public void RankReturnTest() 
        {
            string expectedrank = Rank.Seven.ToString();
            Card testcard = new Card(Suit.Diamonds, Rank.Seven);

            string actualrank = testcard.GetValue();

            Assert.AreEqual(actualrank, expectedrank);
        }

        [TestMethod]
        public void RandomCardTest() 
        { 
            Card testcard1 = new Card();
            Card testcard2 = new Card();

            testcard1.SetRandomCard();
            testcard2.SetRandomCard();

            Assert.AreNotEqual(testcard1, testcard2);
        }

        [TestMethod]
        public void SuitSetTest()
        {
            Card testcard = new Card();
            Suit expectedsuit = Suit.Diamonds;

            testcard.SetSuit(Suit.Diamonds);
            Suit actualsuit = testcard.Suit;

            Assert.AreEqual(expectedsuit, actualsuit);
        }

        [TestMethod]
        public void RankSetTest()
        {
            Card testcard = new Card();
            Rank expectedrank = Rank.Ten;

            testcard.SetRank(Rank.Ten);
            Rank actualrank = testcard.Rank;

            Assert.AreEqual(expectedrank, actualrank);
            
        }
    }
}
