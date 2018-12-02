using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesten.Models
{
    public class Player
    {
        private List<Card> hand;
        private string name;

        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }

        /// <summary>
        /// Asks the player to play a card from their hand given the current top card of the discard pile.
        /// If the player has a playable card(s) in their hand, this will return (the first) playable card and remove that card from their hand.
        /// If the player has no playable cards in their hand, this will return null.
        /// </summary>
        /// <param name="top">The current top card of the discard pile.</param>
        /// <returns>The card this player wants to play, or null if they have nothing to play.</returns>
        public Card Play(Card top)
        {
            foreach (Card card in hand)
            {
                if (card.GetSuit().Equals(top.GetSuit()) || card.GetNumber().Equals(top.GetNumber()))
                {
                    hand.Remove(card);
                    return card;
                }
            }
            return null;
        }

        /// <summary>
        /// Adds the given card to the player's hand
        /// </summary>
        /// <param name="card">The card to add to this player's hand</param>
        public void AddCardToHand(Card card)
        {
            hand.Add(card);
        }

        public List<Card> GetHand()
        {
            return hand;
        }

        public int GetHandSize()
        {
            return hand.Count;
        }

        public string GetName()
        {
            return name;
        }
    }
}
