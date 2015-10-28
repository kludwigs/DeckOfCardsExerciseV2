using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckOfCards;

namespace CardUnitTestProject
{
    [TestClass]
    public class DeckOfCardUnitTests
    {
        [TestMethod]
        public void OneDeck_DeckContains52Cards_IsTrue()
        {
            Deck testdeck = new Deck();
            testdeck.InitalizeTupCards();
            Assert.AreEqual(testdeck.TupCards.Count, 52);
        }
        [TestMethod]
        public void OneDeck_ItemsUnique_IsTrue()
        {
            Deck testdeck = new Deck();
            testdeck.InitalizeTupCards();
            var my = testdeck.TupCards.ToArray();
            CollectionAssert.AllItemsAreUnique(my, "all items are not unique");
        }
        [TestMethod]
        public void OneDeck_AllItemsAreNotNull_NoCardsAreNull()
        {
            Deck testdeck = new Deck();
            testdeck.InitalizeTupCards();
            var my = testdeck.TupCards.ToArray();
            CollectionAssert.AllItemsAreNotNull(my, "all items are not null");
        }
        [TestMethod]
        public void TwoDecks_ShuffleADeckAndCompareToSortedDeck()
        {
            Deck testdeck = new Deck();
            testdeck.InitalizeTupCards();
            testdeck.Shuffle();
            var my = testdeck.TupCards.ToArray();
            var my2 = SortedTestDeck.Instance.Cards.ToArray();
            CollectionAssert.AreNotEqual(my, my2);
        }
        [TestMethod]
        public void TwoDecks_SortADeckAndCompareToSortedDeck()
        {
            Deck testdeck = new Deck();
            testdeck.InitalizeTupCards();
            testdeck.Shuffle();
            testdeck.Sort();
            var my = testdeck.TupCards.ToArray();
            var my2 = SortedTestDeck.Instance.Cards.ToArray();

            CollectionAssert.AreEqual(my, my2);
        }
    }
}
