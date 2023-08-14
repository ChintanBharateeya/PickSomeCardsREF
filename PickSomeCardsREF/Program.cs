// See https://aka.ms/new-console-template for more information
using PickRandomCardsREF;
using System.Transactions;
CardPicker.SetUpCards();
Console.Write("Enter the number of Cards to Print");
string line= Console.ReadLine();
if(int.TryParse(line, out int numberOfCards))
{
    if (numberOfCards > CardPicker.deck.Count)
    {
        Console.WriteLine("The Entry Can't be larger then the Deck, Should be between 1-52");

    }
    foreach(string card in CardPicker.RandomCards(numberOfCards))
    { Console.WriteLine(card); }

}
else
{
    Console.WriteLine("Enter A Valid Number");
}
