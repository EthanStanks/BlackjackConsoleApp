using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab03Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Library.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]
        public void BlackjackHandTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand testInstance = new BlackjackHand();
            ICard card1 = Factory.CreateBlackjackCard(CardFace.A, CardSuit.Hearts);
            ICard card2 = Factory.CreateBlackjackCard(CardFace._8, CardSuit.Hearts);
            ICard card3 = Factory.CreateBlackjackCard(CardFace._10, CardSuit.Hearts);
            testInstance.AddCard(card1);
            testInstance.AddCard(card2);
            Assert.AreEqual(testInstance.Score, 19);
            testInstance.AddCard(card3);
            Assert.AreEqual(testInstance.Score, 19);
        }

        [TestMethod()]
        public void PrintTest()
        {
            Assert.Fail();
        }
    }
}