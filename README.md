# Deck Shuffler

A console app that creates and shuffles a new deck for you to draw from and keeps track fo your hand.

## Includes:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- classes with methods

# Featured Code
## Class With Methods

```C#
  namespace DeckShuffler
{
  public class Card
  {
    // rank
    public string Rank { get; set; }
    // suit
    public string Suit { get; set; }
    // color
    public string Color { get; set; }

    //Method
    public string DisplayCard()
    {
      return $"{Rank} of {Suit}";
    }

    public int GetCardValue()
    {
      if (Rank.ToLower() == "ace") {
          return 11;
      } else if (Rank.ToLower() == "queen" || Rank.ToLower() == "king" || Rank.ToLower() == "jack"){
          return 10;
      } else {
          return int.Parse(Rank);
      }
    }
  }
}
```

## App In Action

![recordit](http://g.recordit.co/day0eoU8QH.gif)
