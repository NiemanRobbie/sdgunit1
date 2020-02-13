using System;
using System.Collections.Generic;

namespace All_Card_on_Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Deck
            var deck = new List<string>();
            var suit = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
            var face = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            for (int suitValue = 0; suitValue < suit.Count; suitValue++)
            {
                for (int faceValue = 0; faceValue < face.Count; faceValue++)
                {
                    // Creating each card
                    var cardDone = face[faceValue] + " of " + suit[suitValue];
                    // Adding card to deck
                    deck.Add(cardDone);


                }
            }
            for (int i = 0; i < deck.Count; i++)
            {
                Console.WriteLine(deck[i]);
            }
            //Create Fisher Yates Algorithm 
            for (int i = 51; i > 0; i--)
            {
                // create a random number to swap the card with given the following guidlines; 
                // where 0 <= j <= i
                Random rand = new Random();
                int randomDeckPosition = rand.Next(0, i + 1);
                Console.WriteLine("RANDOM DECK POSITION: " + randomDeckPosition);
                // swap deck[i] with deck[j] 
                var temp = deck[i];
                Console.WriteLine("ORGINAL CARD: " + deck[i]);
                Console.WriteLine("RANDOM CARD: " + deck[randomDeckPosition]);
                deck[i] = deck[randomDeckPosition];
                deck[randomDeckPosition] = temp;
            }
            // for (int i = 0; i < deck.Count; i++)
            // {
            //     Console.WriteLine(deck[i]);
            // }
            // Pick Top Card
            Console.WriteLine(" TOP CARD " + deck[0]);


        }
    }
}


