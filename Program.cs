using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {

      /****** CREATING THE DECK *******/
      var deck = new List<string>();
      var suits = new List<string>() { "Hearts", "Clubs", "Spades", "Diamonds" };
      var cardValues = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

      //Creating your deck based off of the suits and values list
      for (var i = 0; i < suits.Count; i++)
      {
        for (var n = 0; n < cardValues.Count; n++)
        {
          deck.Add($"{cardValues[n]} of {suits[i]}");
        }
      }



      /****** SHUFFLING THE DECK *******/
      var shuffledDeck = new List<string>();
      Random r = new Random();

      while (deck.Count > 0)
      {
        // Pick a random number j between one and the number of unstruck numbers remaining (inclusive).
        var j = r.Next(deck.Count);

        // Pick a card to be both removed from our og deck and added to our new deck
        var cardSelected = deck[j];
        shuffledDeck.Add(cardSelected);
        deck.Remove(cardSelected);
      }

      // //Check each card in the deck
      // for (var i = 0; i < shuffledDeck.Count; i++) {
      //     Console.WriteLine(shuffledDeck[i]);
      // }




      /****** SHOWING THE DECK *******/
      //  After the deck is shuffled, display the top card.
      Console.WriteLine($"You've drawn a {shuffledDeck[0]}");
      string userInput;
      var x = 1;

      //  Give the user an option to see the next card or quit the program.
      do {
        Console.WriteLine("To draw a card type hit enter type 'q' to quit");
        userInput = Console.ReadLine().ToLower();

        if (userInput != "")
        return;

        Console.WriteLine(shuffledDeck[x]);
        x++;
      } while (userInput == "");
    }
  }
}
