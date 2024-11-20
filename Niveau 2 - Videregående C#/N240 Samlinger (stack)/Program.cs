using N240_Samlinger__stack_;

Pile pile = new Pile();
pile.AddCard(new Card() { Suit = "Clubs", Value = 10 });
pile.AddCard(new Card() { Suit = "Diamonds", Value = 12 });
pile.AddCard(new Card() { Suit = "Hearts", Value = 2 });
pile.ShowPile();

Console.WriteLine();

var card = pile.RemoveCard();
Console.WriteLine(card);

Console.WriteLine();

pile.ShowPile();

Console.WriteLine();