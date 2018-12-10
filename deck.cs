using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            Reset();
            Shuffle();
        }
        public Card Deal()
        {
            if(cards.Count!= 0)
            {
                Card tempCard = cards[0];
                cards.RemoveAt(0);
                return tempCard;
            }
            else
            {
                return null;
            }
        }
        public Deck Reset()
        {
            cards = new List<Card>();
            string[] cardSuits = {"hearts", "diamonds", "spades", "clubs"};
            for(int cardVal = 1; cardVal < 14; cardVal++)
            {
                foreach(string cardSuit in cardSuits)
                {
                    cards.Add(new Card(cardSuit, cardVal));
                }
            }
            return this;
        }
        public Deck Shuffle()
        {
            Random random = new Random();
            for(int i = cards.Count; i > 1; i--)
            {
                // Picks random element to swap.
                int j = random.Next(i); // 0 <= j <= i-1
                Console.WriteLine(cards[j]);
                // Swap.
                Card temp = cards[j];
                cards[j] = cards[i - 1];
                cards[i-1] = temp;
            }
            return this;
        }
    }
}