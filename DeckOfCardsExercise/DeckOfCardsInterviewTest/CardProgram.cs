using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeckOfCards
{
    public class Card
    {
        public enum suit { clubs, diamonds, hearts, spades };
        public enum faces { ace = 1, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king };

        public static int numOfFaces = (int)Enum.GetNames(typeof(faces)).Length;
        public static int numOfSuits = (int)Enum.GetNames(typeof(suit)).Length; 

        public int cardsuit;
        public int cardvalue;

        static public string GetCardValue(int cvalue)
        {
            return ((faces)cvalue).ToString();                  
        }
        static public string GetCardSuit(int svalue)
        {
            return ((suit)svalue).ToString();
        }
        static public string GetCardName(Card card)
        {
            return (GetCardValue(card.cardvalue) + " of " + GetCardSuit(card.cardsuit));
        }
        static public bool AreCardsEqual(Card card1, Card card2)
        {
            return (card1.cardsuit == card2.cardsuit && card1.cardvalue == card2.cardvalue);
        }
    }
    public class Deck
    {
        private int currentCard = 0;

        public List<Card> Cards;

        public void Shuffle()
        {
            currentCard = 0;

            Random rnd = new Random();
            var numOfCards = this.Cards.Count;

            for (int i = 0; i < numOfCards; i++)
            {
                Swap(rnd.Next(numOfCards), rnd.Next(numOfCards));
            }          
        }
        public void Swap(int i, int j)
        {
            var lst = this.Cards;

            var temp = lst[i];
            lst[i] = lst[j];
            lst[j] = temp;
        }

        public int FindCardIndex(int face, int suit)
        {
            return Cards.FindIndex(a => a.cardsuit.Equals(suit) && a.cardvalue.Equals(face));            
        }
        
        public void Sort()
        {
            currentCard = 0;

            int newposition = 0;
            /* Outer Loop Suits*/
            for (int i = 0; i < Card.numOfSuits ; i++)
            {
                /* Inner Loop Faces*/
                for (int j = 1; j < Card.numOfFaces + 1; j++)
                {
                    /* Go through the list find the element and put it at the right index */
                    /* first card ace of clubs will go at index 0 */
                    Swap(FindCardIndex(j,i), newposition++);
                }
            }
        }
        public bool IsSorted()
        {
            int sortposition = 0;
            /* Outer Loop Suits*/
            for (int i = 0; i < Card.numOfSuits; i++)
            {
                /* Inner Loop Faces*/
                for (int j = 1; j < Card.numOfFaces + 1; j++)
                {
                    /* Go through the list find the element verify at right index */
                    if (FindCardIndex(j, i) != sortposition++)
                    {
                        return false;
                    }
                }
            }
            /* If all position are correct then the cards must be sorted */
            return true;
        }
        public bool AreCardsUnique()
        {
            var groups = Cards.GroupBy(t => new { t.cardvalue, t.cardsuit });
            foreach(var group in groups)
            {
                int mp = group.Count();
                if(mp >1)
                    return false;
            }            
            return true;
        }
        
        public Deck()
        {
            Cards = new List<Card>();

            for(int i =0; i< Card.numOfSuits ;i++)
            {
                for (int j = 1; j < Card.numOfFaces + 1; j++)
                {
                    Cards.Add(new Card { cardsuit = i, cardvalue = j });
                }
            }
        }
        public Card DealCard()
        {
            if (currentCard < Cards.Count)
                return (Cards[currentCard]);
            else
                /* No More Cards */
                return null;
        }
    }

    class CardProgram
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            int i = 1;
            
            bool tmp = deck1.AreCardsUnique();

            foreach (var card in deck1.Cards)
                Console.WriteLine("({0}) drew a {1}",i++, Card.GetCardName(card));
            
           
            Console.WriteLine("\n\nLet's Shuffle The Deck!\n\n");

            deck1.Shuffle();

            i = 1;

            foreach (var card in deck1.Cards)
                Console.WriteLine("({0}) drew a {1}", i++, Card.GetCardName(card));

            Console.WriteLine("\n\nLet's Sort The Deck!\n\n");

            deck1.Sort();

            if (deck1.IsSorted())
            {
                Console.WriteLine("\nYes the Deck is Sorted\n");
            }
            i = 1;

            foreach (var card in deck1.Cards)
                Console.WriteLine("({0}) drew a {1}", i++, Card.GetCardName(card));

            Console.ReadLine();
        }
    }
}