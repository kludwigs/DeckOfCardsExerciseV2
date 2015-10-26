using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckOfCards;

namespace CardUnitTestProject
{
    [TestClass]
    public class DeckOfCardUnitTests
    {        
        [TestMethod]
        public void OneDeck_IsItSortedWhenInitialized_WillBeSorted()
        {
            Deck testdeck = new Deck();

            Assert.AreEqual(testdeck.IsSorted(), true);
        }

        [TestMethod]
        public void OneDeck_DeckShuffled_WillNotBeSorted()
        {
            Deck testdeck = new Deck();
            testdeck.Shuffle();
            Assert.AreEqual(testdeck.IsSorted(), false);
        }
        [TestMethod]
        public void OneDeck_ShuffledThenSorted_WillBeSorted()
        {
            Deck testdeck = new Deck();
            testdeck.Shuffle();
            testdeck.Sort();
            Assert.AreEqual(testdeck.IsSorted(), true);
        }
        [TestMethod]
        public void OneDeck_InitializeT_NoDuplicates()
        {
            Deck testdeck = new Deck();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
        [TestMethod]
        public void OneDeck_InitializeThenShuffle_NoDuplicates()
        {
            Deck testdeck = new Deck();
            testdeck.Shuffle();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
        [TestMethod]
        public void OneDeck_InitializeThenShuffleThenSort_NoDuplicates()
        {
            Deck testdeck = new Deck();
            testdeck.Shuffle();
            testdeck.Sort();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
        [TestMethod]
        public void TwoDeck_ShuffleOneSortOther_BothHaveKeptState()
        {
            Deck testdeck = new Deck();
            Deck testdeck2 = new Deck();
            testdeck.Shuffle();
            testdeck.Sort();
            testdeck2.Shuffle();

            Assert.AreEqual(testdeck.IsSorted(), true);
            Assert.AreEqual(testdeck2.IsSorted(), false);
        }
    }
}
