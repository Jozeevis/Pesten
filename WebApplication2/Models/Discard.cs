using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesten.Models
{
    public class Discard
    {
        private List<Card> discard;

        public Discard(Card start)
        {
            discard = new List<Card>();
            discard.Add(start);
        }

        /// <summary>
        /// Returns the top card of the discard pile, but does not remove it from the pile
        /// </summary>
        /// <returns>The current top card of the pile</returns>
        public Card PeekTopCard()
        {
            return discard[discard.Count - 1];
        }

        /// <summary>
        /// Adds the given card to the discard pile, making it the new top card
        /// </summary>
        /// <param name="card">The card to be added</param>
        public void AddCard(Card card)
        {
            discard.Add(card);
        }

        /// <summary>
        /// Returns all but the top card of the discard pile and removes them from the pile.
        /// This can be used for reshuffling if the deck is empty.
        /// </summary>
        /// <returns>The former discard pile excluding the current top card</returns>
        public List<Card> GetAllButTop()
        {
            // Find top card of the pile
            Card top = PeekTopCard();
            // Take out all the other cards
            List<Card> output = discard;
            output.Remove(top);
            // Make new discard pile with only top card
            discard = new List<Card>();
            discard.Add(top);
            // Output the list of other cards
            return output;
        }
    }
}
