using System;
using System.Collections.Generic;
using System.Linq;

namespace Card
{
    public class CardDeck
    {
        private List<Card> cards;

        public CardDeck()
        {   // Mazo vacío
            cards = new List<Card>();

            // Agregar 13 cartas de cada uno de los 4 palos
            for (int value = 1; value <= 13; value ++)  
            {      
                for (int suit = 1; suit <= 4; suit++)
                {
                    Card aCard = new Card(value, suit);
                    cards.Add(aCard);
                }
            }
        }
        public void shuffle()
        {
            Random rnd = new Random();
            cards = cards.OrderBy(Card => rnd.Next()).ToList();
        }
        public Card getTop()
        {
            return cards[0];
        }
        public void draw()
        {
            cards.RemoveAt(index:0);
        }
    }
}