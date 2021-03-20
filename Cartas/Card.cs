namespace Card
{
    public class Card
    {
        public int value { get; set; }
        public int suit { get; set; }

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public string info()
        {
            return "Value: " + value +
                    " Suit: " + suit;
        }
    }
}