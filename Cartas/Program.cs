using System;

namespace Card
{
   internal class Program
    {
        public static void Main(string[] args)
        {
            // Mazo ordenado
            CardDeck mazo = new CardDeck();
            for (int i = 0; i < 5; i++)
            {
                Card aCard = mazo.getTop();
                mazo.draw();
                Console.WriteLine(aCard.info());
            }
            // Mazo desordenado
            mazo.shuffle();
            for (int i = 0; i < 5; i++)
            {
                Card aCard = mazo.getTop();
                mazo.draw();
                Console.WriteLine(aCard.info());
            }
        }
    }
}
