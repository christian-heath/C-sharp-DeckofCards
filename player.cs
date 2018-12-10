using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string name;
        public List<Card> hand;
        public void Draw(Deck shuffledDeck)
        {
            hand.Add(shuffledDeck.Deal());
        }
        public Card Discard()
        {
            if(hand.Count != 0)
            {
                Card tempCard = hand[0];
                hand.RemoveAt(0);
                return tempCard;
            }
            else
            {
                return null;
            }
        }
    }
}