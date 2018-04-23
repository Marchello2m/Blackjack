using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Clases
{
    public class Deck
    {
        public char[] Suits = { 'H', 'D', 'S', 'C' };
        public string[] Values = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};


        public List<Card>Cards;

        public Deck()
        {
            Cards = new List<Card>();
            foreach(char s in Suits)
            {
                foreach(string v in Values)// apstrada vertibas
                {
                    Cards.Add(new Card(v, s));//pievieno karti karshu kavai
                }
            }

        }

        public Card TakeCard()
        {
            Card newCard = Cards[0];
            Cards.RemoveAt(0);

            return newCard;// atgriz karti kas iznjemta no saraksta
        }

        public Deck TakeNewDeck()
        {
            return null;
        }
    }
}
