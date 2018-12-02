using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesten.Models
{

    public class Dealer
    {
        public readonly int NROFPLAYERS = 4;
        public readonly string[] PLAYERNAMES = { "Lars", "Wiel", "Michiel", "Daan" };
        public readonly int STARTINGHANDSIZE = 7;

        private List<Player> players;
        private Deck deck;
        private Discard discard;

        private int currentTurn = 0;

        public Dealer()
        {
            players = new List<Player>();
            // Make the correct amount of players
            for(int i = 0; i < NROFPLAYERS; i++)
            {
                string name;
                // Use a name from the PlayerNames list if possible, otherwise make a generic one
                if (i < PLAYERNAMES.Length) {
                    name = PLAYERNAMES[i];
                }
                else {
                    name = "Player" + (i+1);
                }
                players.Add(new Player(name));
            }

            // Make the deck
            deck = new Deck();

            // Deal the correct amount of starting cards to each player
            for (int i = 0; i < STARTINGHANDSIZE; i++)
            {
                foreach (Player player in players)
                {
                    player.AddCardToHand(deck.GetTopCard());
                }
            }

            // Make the discard pile and play the first card
            discard = new Discard(deck.GetTopCard());
        }

        /// <summary>
        /// Will ask the player whose turn it currently is to make a play or reshuffle the deck with the discard pile if it's empty
        /// </summary>
        public void Next()
        {
            // If the deck is empty, reshuffle it with the discard pile
            if (deck.GetDeckSize() <= 0)
            {
                deck.AddCards(discard.GetAllButTop());
            }
            else
            {
                // Ask the current player to make a play
                Player currentPlayer = players[currentTurn];
                Card play = currentPlayer.Play(discard.PeekTopCard());
                // If they can't make a play, have them draw a card
                if (play == null)
                {
                    currentPlayer.AddCardToHand(deck.GetTopCard());
                }
                // If they can make a play, add that card to the discard pile
                else
                {
                    discard.AddCard(play);
                }
                // Adjust the current turn indicator to the next player, or back to 0 if all players have had a turn
                currentTurn++;
                if (currentTurn > NROFPLAYERS)
                {
                    currentTurn = 0;
                }
            }
        }
    }
}
