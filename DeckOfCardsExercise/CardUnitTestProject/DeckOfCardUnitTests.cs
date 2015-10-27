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
            testdeck.InitializeFullDeck();

            Assert.AreEqual(testdeck.Cards.Count == 52, true);
        }

        [TestMethod]
        public void OneDeck_IsItSortedWhenInitialized_WillBeSorted()
        {
            Deck testdeck = new Deck();
            testdeck.InitializeFullDeck();
            Assert.AreEqual(testdeck.IsSorted(), true);
        }

        [TestMethod]
        public void OneDeck_DeckShuffled_WillNotBeSorted()
        {
            Deck testdeck = new Deck();
            testdeck.InitializeFullDeck();
            testdeck.Shuffle();
            Assert.AreEqual(testdeck.IsSorted(), false);
        }
        [TestMethod]
        public void OneDeck_ShuffledThenSorted_WillBeSorted()
        {
            Deck testdeck = new Deck();
            testdeck.InitializeFullDeck();
            testdeck.Shuffle();
            testdeck.Sort();
            Assert.AreEqual(testdeck.IsSorted(), true);
        }
        [TestMethod]
        public void OneDeck_InitializeT_NoDuplicates()
        {
            Deck testdeck = new Deck();
            testdeck.InitializeFullDeck();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
        [TestMethod]
        public void OneDeck_InitializeThenShuffle_NoDuplicates()
        {
            Deck testdeck = new Deck();
            testdeck.InitializeFullDeck();
            testdeck.Shuffle();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
        [TestMethod]
        public void OneDeck_InitializeThenShuffleThenSort_NoDuplicates()
        {
            Deck testdeck = new Deck();
            testdeck.InitializeFullDeck();
            testdeck.Shuffle();
            testdeck.Sort();
            Assert.AreEqual(testdeck.AreCardsUnique(), true);
        }
        [TestMethod]
        public void TwoDeck_ShuffleOneSortOther_BothHaveKeptState()
        {
            Deck testdeck = new Deck();
            Deck testdeck2 = new Deck();

            testdeck.InitializeFullDeck();
            testdeck2.InitializeFullDeck();

            testdeck.Shuffle();
            testdeck.Sort();
            testdeck2.Shuffle();

            Assert.AreEqual(testdeck.IsSorted(), true);
            Assert.AreEqual(testdeck2.IsSorted(), false);
        }
        [TestMethod]
        public void OneDeck_CreateTwoCardsTheSameSuitAndValue_DeckCardsWillNotBeUnique()
        {
            Deck testdeck = new Deck();
            testdeck.Cards.Add(new Card { cardsuit = 1, cardvalue = 3 });
            testdeck.Cards.Add(new Card { cardsuit = 3, cardvalue = 1 });
            testdeck.Cards.Add(new Card { cardsuit = 1, cardvalue = 3 });

            Assert.AreEqual(testdeck.Cards.Count == 3, true);

            Assert.AreEqual(testdeck.AreCardsUnique(), false);
        }
        [TestMethod]
        public void OneDeck_CreateTwoCardsTheSameSuitAndValueOnFullDeck_DeckCardsWillNotBeUnique()
        {
            Deck testdeck = new Deck();
            testdeck.InitializeFullDeck();
            testdeck.Cards.Add(new Card { cardsuit = 1, cardvalue = 3 });

            Assert.AreEqual(testdeck.Cards.Count == 53, true);
            Assert.AreEqual(testdeck.AreCardsUnique(), false);
        }
    }
}
