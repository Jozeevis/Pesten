using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesten.Models
{
    public enum Suit { Spades, Diamonds, Hearts, Clubs }

    public class Card
    {
        private Suit suit;
        private int number;

        public Card(Suit s, int n )
        {
            if (n >= 1 && n <= 13)
            {
                suit = s;
                number = n;
            }
            else
                throw new Exception("Number of the card has to be between 1 and 13, but was " + n);
        }

        public override String ToString()
        {
            string output = "";

            switch(this.number)
            {
                case 1: output += "Ace of "; break;
                case 11: output += "Jack of "; break;
                case 12: output += "Queen of "; break;
                case 13: output += "King of "; break;
                default: output += number + " of "; break;
            }

            switch(this.suit)
            {
                case Suit.Spades: output += "Spades"; break;
                case Suit.Diamonds: output += "Diamonds"; break;
                case Suit.Hearts: output += "Hearts"; break;
                case Suit.Clubs: output += "Clubs"; break;
                default: output += "unknown suit"; break;
            }

            return output;
        }

        public String ToShortString()
        {
            string output = "";

            switch (this.number)
            {
                case 1: output += "A"; break;
                case 11: output += "J"; break;
                case 12: output += "Q"; break;
                case 13: output += "K"; break;
                default: output += number; break;
            }

            switch (this.suit)
            {
                case Suit.Spades: output += "♠"; break;
                case Suit.Diamonds: output += "♦"; break;
                case Suit.Hearts: output += "♥"; break;
                case Suit.Clubs: output += "♣"; break;
                default: output += "?"; break;
            }

            return output;
        }

        public Suit GetSuit()
        {
            return suit;
        }

        public int GetNumber()
        {
            return number;
        }
    }
}
