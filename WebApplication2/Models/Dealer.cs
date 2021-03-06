﻿using System;
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
        public readonly int LOGCOUNT = 10;

        private List<Player> players;
        private Deck deck;
        private Discard discard;
        private List<string> log;
        private Boolean done = false;

        private int currentTurn = 0;

        private static readonly Dealer _dealer = new Dealer();
        public static Dealer GetDealer()
        {
            return _dealer;
        }

        private Dealer()
        {
            NewGame();
        }

        /// <summary>
        /// Sets up a new game
        /// </summary>
        private void NewGame()
        {
            log = new List<string>();

            players = new List<Player>();
            // Make the correct amount of players
            for (int i = 0; i < NROFPLAYERS; i++)
            {
                string name;
                // Use a name from the PlayerNames list if possible, otherwise make a generic one
                if (i < PLAYERNAMES.Length)
                {
                    name = PLAYERNAMES[i];
                }
                else
                {
                    name = "Player" + (i + 1);
                }
                players.Add(new Player(name));
            }

            String logline = "Starting game with players ";
            for(int i = 0; i < players.Count; i++)
            {
                if (i == players.Count - 1)
                    logline += "and ";
                logline += players[i].GetName();
                if (i < players.Count - 1)
                    logline += ", ";
                else
                    logline += ".";
            }
            AddToLog(logline);

            // Make the deck
            deck = new Deck();

            // Deal the correct amount of starting cards to each player
            foreach (Player player in players)
            {
                logline = player.GetName() + " has been dealt: ";
                for (int i = 0; i < STARTINGHANDSIZE; i++)
                {
                    Card card = deck.GetTopCard();
                    player.AddCardToHand(card);
                    logline += card.ToShortString() + " ";
                }
                AddToLog(logline);
            }

            // Make the discard pile and play the first card
            Card top = deck.GetTopCard();
            discard = new Discard(top);
            AddToLog("Top card is: " + top.ToShortString());

            done = false;
        }

        /// <summary>
        /// Will ask the player whose turn it currently is to make a play or reshuffle the deck with the discard pile if it's empty
        /// </summary>
        public Boolean Next()
        {
            if (!done)
            {
                string output;
                // If the deck is empty, reshuffle it with the discard pile
                if (deck.GetDeckSize() <= 0)
                {
                    deck.AddCards(discard.GetAllButTop());
                    output = "Deck was shuffled";
                }
                else
                {
                    // Ask the current player to make a play
                    Player currentPlayer = players[currentTurn];
                    Card play = currentPlayer.Play(discard.PeekTopCard());
                    // If they can't make a play, have them draw a card
                    if (play == null)
                    {
                        Card card = deck.GetTopCard();
                        currentPlayer.AddCardToHand(card);
                        output = currentPlayer.GetName() + " can't play a card, and drew instead: " + card.ToShortString();
                    }
                    // If they can make a play, add that card to the discard pile
                    else
                    {
                        discard.AddCard(play);
                        output = currentPlayer.GetName() + " played " + play.ToShortString() + ".";
                        if (currentPlayer.GetHandSize() == 1)
                        {
                            output += "\nThey only have 1 card left in their hand!";
                        }
                        else if (currentPlayer.GetHandSize() <= 0)
                        {
                            output += "\nThey have won the game!";
                            done = true;
                        }
                    }
                    // Adjust the current turn indicator to the next player, or back to 0 if all players have had a turn
                    currentTurn++;
                    if (currentTurn >= NROFPLAYERS)
                    {
                        currentTurn = 0;
                    }
                }
                AddToLog(output);
                return true;
            }
            AddToLog("The game is already over!");
            return true;
        }

        private void AddToLog (string item)
        {
            if (log.Count >= LOGCOUNT) {
                log.RemoveAt(0);
            }
            log.Add(item);
        }

        public List<string> GetLog()
        {
            return log;
        }

        public Card GetTopCard()
        {
            return discard.PeekTopCard();
        }

        public Card GetDeckTop()
        {
            return deck.PeekTopCard();
        }

        public int GetDeckSize()
        {
            return deck.GetDeckSize();
        }

        public int GetDiscardSize()
        {
            return discard.GetSize();
        }

        public int GetCurrentTurn()
        {
            return currentTurn;
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        public void Reset()
        {
            NewGame();
        }
    }
}
