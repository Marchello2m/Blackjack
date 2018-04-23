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

        public Deck()       // funkcija bez ; ari ir funkcija
        {
            Cards = new List<Card>();
            foreach(char s in Suits)         // apstrad mastus 
            {                                                                       // izveido visas iespejamas kombinacijas no saraksta
                foreach(string v in Values)// apstrada vertibas
                {
                    Cards.Add(new Card(v, s));//pievieno karti karshu kavai       14 masti 13 kartis
                }
            }

        }

        public Card TakeCard()                // funkcija
        {
            Card newCard = Cards[0];// panjem karti
            Cards.RemoveAt(0);//iznjem karti no karshu kavas

            return newCard;// atgriz karti kas iznjemta no saraksta
        }

        public static Deck TakeNewDeck()
        {
            return new Deck();
        }
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid()).ToList();            // sakartos random kartiba       guid uztaisa unikalu kartibu un divi vienadi nav iespejam

        }                     // jauna funkcija izveido jaunu saucamo ko unikali sakarto


    }
}
