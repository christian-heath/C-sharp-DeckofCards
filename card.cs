using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Card
    {
        public string stringVal
        {
            get
            {
                if(val == 1)
                {
                    return "Ace";
                }
                else if(val == 11)
                {
                    return "Jack";
                }
                else if(val == 12)
                {
                    return "Queen";
                }
                else if(val == 13)
                {
                    return "King";
                }
                else
                {
                    return val.ToString();
                }
            }
        }
        public string suit;
        public int val;
        public Card(string cardSuit, int cardVal)
        {
            suit = cardSuit;
            val = cardVal;
        }
        public override string ToString()
        {
            return stringVal + " of " + suit;
        }
    }
}