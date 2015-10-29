using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class CardProgram
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();


            /* Read The Initalized Cards */
            foreach (var card in deck1.TupCards)
            {
                Console.Write("drew {0} of {1}\n", Card.GetCardValue(card.Item1), Card.GetCardSuit(card.Item2));
            }

            /* Shuffle Cards */
            Console.Write("\n\nShuffle The Deck\n\n");
            deck1.Shuffle();

            /* Read Shuffled Cards */
            foreach (var card in deck1.TupCards)
            {
                Console.Write("drew {0} of {1}\n", Card.GetCardValue(card.Item1), Card.GetCardSuit(card.Item2));
            }

            /* Sort Them Again */
            Console.Write("\n\nSort The Deck\n\n");
            deck1.Sort();
            foreach (var card in deck1.TupCards)
            {
                Console.Write("drew {0} of {1}\n", Card.GetCardValue(card.Item1), Card.GetCardSuit(card.Item2));
            }

            Console.ReadLine();
        }

    }
}