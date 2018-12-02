using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesten.Models
{
    public class Deck
    {
        private List<Card> deck;
        private Random r;

        public Deck()
        {
            deck = new List<Card>();
            r = new Random();
            GenerateDeck();
        }

        /// <summary>
        /// Empties the current deck and generates a new one with all cards of all suits and number combinations (standard 52).
        /// The deck will end up being shuffled.
        /// This can be used to start a new game for example.
        /// </summary>
        public void GenerateDeck()
        {
            EmptyDeck();
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                for(int n = 2; n<=13; n++)
                {
                    deck.Add(new Card(suit, n));
                }
            }
            Shuffle<Card>(deck,r);
        }

        /// <summary>
        /// Returns the top card of the deck and removes it from the deck.
        /// </summary>
        /// <returns>The card that was at the top of the deck.</returns>
        public Card GetTopCard()
        {
            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// Will shuffle the given list using the given random seed
        /// </summary>
        /// <typeparam name="T">The type of the list</typeparam>
        /// <param name="list">The list to be shuffled</param>
        /// <param name="rnd">The random seed</param>
        private void Shuffle<T>(IList<T> list, Random rnd)
        {
            for (var i = 0; i < list.Count; i++)
                Swap(list, i, rnd.Next(i, list.Count));
        }

        /// <summary>
        /// Swaps the items at the given indices in the given list
        /// </summary>
        /// <typeparam name="T">The type of the list</typeparam>
        /// <param name="list">The list to swap items in</param>
        /// <param name="i">The index of the first item to be swapped</param>
        /// <param name="j">The index of the second item to be swapped</param>
        private void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        /// <summary>
        /// Adds all given cards to the deck and shuffles it
        /// Should only be used if the deck is empty.
        /// Throws an exception if deck is not empty.
        /// </summary>
        /// <param name="cards">The list of cards to be added to the deck.</param>
        public void AddCards(List<Card> cards)
        {
            if (deck.Count > 0)
            {
                throw new Exception("Cards were added to deck but deck was not empty.");
            }
            else
            {
                deck = cards;
                Shuffle<Card>(deck, r);
            }
        }

        /// <summary>
        /// Empties the current deck
        /// </summary>
        public void EmptyDeck()
        {
            deck.Clear();
        }

        /// <summary>
        /// Gives the current deck size
        /// </summary>
        /// <returns>The current size of the deck</returns>
        public int GetDeckSize()
        {
            return deck.Count;
        }
    }
}
