using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public static class Card
    {
        public enum suit { clubs, diamonds, hearts, spades };
        public enum faces { ace = 1, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king };

        public readonly static int numOfFaces = (int)Enum.GetNames(typeof(faces)).Length;
        public readonly static int numOfSuits = (int)Enum.GetNames(typeof(suit)).Length;

        /*Functions used for reading card values in main*/
        static public string GetCardValue(int cvalue)
        {
            return ((faces)cvalue).ToString();
        }
        static public string GetCardSuit(int svalue)
        {
            return ((suit)svalue).ToString();
        }
    }
    public class Deck
    {
        private List<Tuple<int, int>> _TupCards = new List<Tuple<int, int>>();

        public List<Tuple<int, int>> TupCards
        {
            get { return _TupCards; }
            protected set { _TupCards = value; }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            var numOfCards = this.TupCards.Count;

            for (int i = 0; i < numOfCards; i++)
            {
                Swap(i, rnd.Next(numOfCards));
            }
        }
        private void Swap(int i, int j)
        {
            var lst = this.TupCards;

            var temp = lst[i];
            lst[i] = lst[j];
            lst[j] = temp;
        }
        public void Sort()
        {
            /* Sort By Suit Then by Value */
            TupCards = TupCards.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();
        }
        public Deck()
        {
            TupCards.Clear();

            for (int i = 0; i < Card.numOfSuits; i++)
            {
                for (int j = 1; j < Card.numOfFaces + 1; j++)
                {
                    TupCards.Add(Tuple.Create(j, i));
                }
            }
        }
    }
    public class SortedTestDeck
    {
        private static SortedTestDeck _instance = null;

        private List<Tuple<int, int>> _cards;

        public List<Tuple<int, int>> Cards
        {
            get
            {
                if (_cards == null)
                {
                    _cards = new List<Tuple<int, int>>();
                    InitializeCards(_cards);
                    return _cards;
                }
                return _cards;
            }
            protected set { _cards = value; }
        }

        public static SortedTestDeck Instance
        {
            get { return _instance ?? (_instance = new SortedTestDeck()); }
        }

        private static void InitializeCards(List<Tuple<int, int>> SortedCards)
        {
            SortedCards.Add(Tuple.Create(1, 0));
            SortedCards.Add(Tuple.Create(2, 0));
            SortedCards.Add(Tuple.Create(3, 0));
            SortedCards.Add(Tuple.Create(4, 0));
            SortedCards.Add(Tuple.Create(5, 0));
            SortedCards.Add(Tuple.Create(6, 0));
            SortedCards.Add(Tuple.Create(7, 0));
            SortedCards.Add(Tuple.Create(8, 0));
            SortedCards.Add(Tuple.Create(9, 0));
            SortedCards.Add(Tuple.Create(10, 0));
            SortedCards.Add(Tuple.Create(11, 0));
            SortedCards.Add(Tuple.Create(12, 0));
            SortedCards.Add(Tuple.Create(13, 0));

            SortedCards.Add(Tuple.Create(1, 1));
            SortedCards.Add(Tuple.Create(2, 1));
            SortedCards.Add(Tuple.Create(3, 1));
            SortedCards.Add(Tuple.Create(4, 1));
            SortedCards.Add(Tuple.Create(5, 1));
            SortedCards.Add(Tuple.Create(6, 1));
            SortedCards.Add(Tuple.Create(7, 1));
            SortedCards.Add(Tuple.Create(8, 1));
            SortedCards.Add(Tuple.Create(9, 1));
            SortedCards.Add(Tuple.Create(10, 1));
            SortedCards.Add(Tuple.Create(11, 1));
            SortedCards.Add(Tuple.Create(12, 1));
            SortedCards.Add(Tuple.Create(13, 1));

            SortedCards.Add(Tuple.Create(1, 2));
            SortedCards.Add(Tuple.Create(2, 2));
            SortedCards.Add(Tuple.Create(3, 2));
            SortedCards.Add(Tuple.Create(4, 2));
            SortedCards.Add(Tuple.Create(5, 2));
            SortedCards.Add(Tuple.Create(6, 2));
            SortedCards.Add(Tuple.Create(7, 2));
            SortedCards.Add(Tuple.Create(8, 2));
            SortedCards.Add(Tuple.Create(9, 2));
            SortedCards.Add(Tuple.Create(10, 2));
            SortedCards.Add(Tuple.Create(11, 2));
            SortedCards.Add(Tuple.Create(12, 2));
            SortedCards.Add(Tuple.Create(13, 2));

            SortedCards.Add(Tuple.Create(1, 3));
            SortedCards.Add(Tuple.Create(2, 3));
            SortedCards.Add(Tuple.Create(3, 3));
            SortedCards.Add(Tuple.Create(4, 3));
            SortedCards.Add(Tuple.Create(5, 3));
            SortedCards.Add(Tuple.Create(6, 3));
            SortedCards.Add(Tuple.Create(7, 3));
            SortedCards.Add(Tuple.Create(8, 3));
            SortedCards.Add(Tuple.Create(9, 3));
            SortedCards.Add(Tuple.Create(10, 3));
            SortedCards.Add(Tuple.Create(11, 3));
            SortedCards.Add(Tuple.Create(12, 3));
            SortedCards.Add(Tuple.Create(13, 3));
        }
    }
}