using System;
using System.Collections.Generic;

namespace blackjackgame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome the user to the game
            Console.WriteLine("Welcome to Blackjack!");
            Console.WriteLine("Closest to 21 wins, if you go over you lose.");
            // Creating New Deck of Cards
            var deck = new List<Card>();
            var suit = new List<string>() { "hearts", "clubs", "diamonds", "spades" };
            var rank = new List<string>() { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
            // Shuffle Cards
            for (int i = 0; i < suit.Count; i++)
            {
                for (int j = 0; j < rank.Count; j++)
                {
                    var card = new Card();
                    card.rank = rank[j];
                    card.suit = suit[i];
                    deck.Add(card);
                }
            }
            for (int i = deck.Count - 1; i >= 1; i--)
            {
                var j = new Random().Next(i);
                var temp = deck[j];
                deck[j] = deck[i];
                deck[i] = temp;
            }
            // Player receives first two cards

            var playerHand = new List<Card>();

            Console.WriteLine($"Your first card is {deck[0].DisplayCard()} has a value of {deck[0].GetCardValue()}");
            playerHand.Add(deck[0]);
            deck.RemoveAt(0);

            Console.WriteLine($"Your second card is {deck[0].DisplayCard()} has a value of {deck[0].GetCardValue()}");
            playerHand.Add(deck[0]);
            deck.RemoveAt(0);

            // Players cards displayed with value of the cards
            string input = "";
            while (input == "" && deck.Count > 0)
            {
                var total = 0;
                for (int i = 0; i < playerHand.Count; i++)
                {
                    total += playerHand[i].GetCardValue();
                }
                Console.WriteLine($"The current total is {total}");

                // Player asked if they want to 'stay' or 'hit'
                // Next card is displayed if user chooses to 'hit', moves to dealers hand if 'stay'
                Console.WriteLine("Press Enter to 'Hit' or No to 'Stay'");
                input = Console.ReadLine().ToLower();
                if (input == "")
                {
                    Console.WriteLine($"The next card is {deck[0].DisplayCard()} has a value of {deck[0].GetCardValue()}");
                    playerHand.Add(deck[0]);
                    deck.RemoveAt(0);
                }
                else if (input == "no")
                {
                    Console.WriteLine($"You stayed at {total}");
                }
            }
            Console.WriteLine("Lets see what the dealer has.");

            // Display the dealers cards and total
            var dealerHand = new List<Card>();

            Console.WriteLine($"The dealers first card is {deck[0].DisplayCard()} has a value of {deck[0].GetCardValue()}");
            dealerHand.Add(deck[0]);
            deck.RemoveAt(0);

            Console.WriteLine($"The dealers second card is {deck[0].DisplayCard()} has a value of {deck[0].GetCardValue()}");
            dealerHand.Add(deck[0]);
            deck.RemoveAt(0);

            while (input == "" && deck.Count > 0)
            {
                var total = 0;
                for (int i = 0; i < dealerHand.Count; i++)
                {
                    total = dealerHand[i].GetCardValue();
                }
                Console.WriteLine($"The current total is {total}");
            }
            // Display a winner based on who is closer to 21
            // Give the player an option to play again or quit
        }
    }
}

