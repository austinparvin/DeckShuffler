using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      string userInput;
      // /********************** CREATING THE PLAYERS ***************************/
      // var players = new List<string>();
      // string userInput;

      // //Ask players to enter their name and create an empty list named {name}Hand
      // do
      // {
      //   Console.WriteLine("Please enter the players name and hit enter, type 'done' when done");
      //   userInput = Console.ReadLine().ToLower();

      //   if (userInput != "done")
      //   {
      //     Console.WriteLine($"Welcome {userInput}");
      //     players.Add(userInput);
      //   }

      // } while (userInput != "done");

      // /********************** CREATING THE PLAYER HANDS ***************************/
      // Dictionary<string, List<string>> playerRef = new Dictionary<string, List<string>>();
      // for (var i = 0; i < players.Count; i++)
      // {
      //   playerRef.Add(players[i],new List<string>());
      // }



     /********************** CREATING THE DECK ***************************/
      var playerHand = new List<string>();

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



      /********************** SHUFFLING THE DECK ***************************/
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




       /********************** SHOWING THE DECK ***************************/
      //  After the deck is shuffled, display the top card.
      Console.WriteLine($"You've drawn a {shuffledDeck[0]}");
      playerHand.Add(shuffledDeck[0]);

      var x = 1;


      //  Give the user an option to see the next card or quit the program.
      do
      {
        Console.WriteLine("To draw a card type hit enter type 'q' to quit");
        userInput = Console.ReadLine().ToLower();

        if (userInput != "")
          return;

        Console.WriteLine($"You've drawn a {shuffledDeck[x]}");
        playerHand.Add(shuffledDeck[x]);
        x++;

        //Check each card in the deck
        Console.WriteLine("Your hand:");
        for (var i = 0; i < playerHand.Count; i++)
        {
          Console.WriteLine(playerHand[i]);
        }
      } while (userInput == "");


    }
  }
}
