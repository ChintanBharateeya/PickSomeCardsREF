using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCardsREF
{
    internal class CardPicker
    {
        public static List<string> deck = new List<string>();
        public static List<string> SetUpCards()
        {
            List<string> suits = new List<string>() { "Spade", "Club", "Heart", "Diamond" };
            List<string> ranks = new List<string>() { "2", "3", "4", "5","6", "7", "8",
                                                      "9", "10", "Jack","Queen","King",
                                                                                "Ace" };
            
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    deck.Add($"{rank} of {suit}");
                }
            }
            return deck;
        }
        int cards = 0;
        public static List<string> RandomCards(int numberOfCards)
        {
            Random random = new Random();
            List<string> pickedCards = new List<string>();
            for (int i=0; i<numberOfCards; i++)
            {
                int randomNumber = random.Next(deck.Count);
                pickedCards.Add (deck[randomNumber]);
                deck.RemoveAt(randomNumber);


            }
            return pickedCards;
        }
        
    }
}
