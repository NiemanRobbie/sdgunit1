namespace blackjackgame
{
    public class Card
    {
        // properties
        // rank
        public string rank { get; set; }
        // suit
        public string suit { get; set; }

        // method
        public string DisplayCard()
        {
            return $"{rank} of {suit}";

        }
        public int GetCardValue()
        {
            if (rank == "ace")
            {
                return 11;
            }
            else if (rank == "queen" || rank == "king" || rank == "jack")
            {
                return 10;
            }
            else
            {
                return int.Parse(rank);
            }
        }
    }
}