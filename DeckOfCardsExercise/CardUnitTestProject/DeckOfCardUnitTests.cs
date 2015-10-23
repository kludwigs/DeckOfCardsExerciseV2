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

        public void OneDeck_InitializeThenShuffle_NoDulicates()
        {
            Deck testdeck = new Deck();
            testdeck.Shuffle();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
        public void OneDeck_InitializeThenShuffleThenSort_NoDulicates()
        {
            Deck testdeck = new Deck();
            testdeck.Shuffle();
            testdeck.Sort();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
    }
}
