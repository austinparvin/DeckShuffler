using System;
using System.Collections.Generic;

namespace DeckShuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            //  /********************** CREATING THE DECK ***************************/
            var deck = new List<Card>();
            var suits = new List<string>() { "Hearts", "Clubs", "Spades", "Diamonds" };
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            //Creating your deck based off of the suits and values list
            for (var i = 0; i < suits.Count; i++)
            {
                for (var n = 0; n < ranks.Count; n++)
                {
                    var card = new Card();
                    card.Rank = ranks[n];
                    card.Suit = suits[i];
                    if (card.Suit == "diamonds" || card.Suit == "hearts")
                    {
                        card.Color = "red";
                    }
                    else
                    {
                        card.Color = "black";
                    }
                    deck.Add(card);
                }
            }




            //   /********************** SHUFFLING THE DECK ***************************/

            for (int i = deck.Count - 1; i >= 0; i--)
            {

                var j = new Random().Next(deck.Count);
                var temp = deck[j];
                deck[j] = deck[i];
                deck[i] = temp;
            }


            var playerHand = new List<Card>();


            /********************** SHOWING THE DECK ***************************/
            //  After the deck is shuffled, display the top card.
            // Console.WriteLine($"\nYou've drawn a {deck[0].DisplayCard()} and has a value of {deck[0].GetCardValue()}");
            // playerHand.Add(deck[0]);
            // deck.RemoveAt(0);

            var userInput = "";

            Console.WriteLine("\nTo draw a card type hit enter type 'q' to quit\n");
            while (userInput == "" && deck.Count > 0)
            {
                var totalHandValue = 0;
                for (int i = 0; i < playerHand.Count; i++)
                {
                    totalHandValue += playerHand[i].GetCardValue();
                }

                Console.WriteLine($"Hand Total: {totalHandValue}");



                userInput = Console.ReadLine().ToLower();
                if (userInput == "")
                {

                    Console.WriteLine($"You've drawn a {deck[0].DisplayCard()} and has a value of {deck[0].GetCardValue()}");
                    playerHand.Add(deck[0]);
                    deck.RemoveAt(0);
                }
            }
        }
    }
}
