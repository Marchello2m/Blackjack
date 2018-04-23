using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Clases
{
   public class Player
    {
        public List<Card> Cards;// definaicja bus mainigais ar shadu tipu ,manigais kasrshu saraksts vinjsh ir noll nav definets

        public Player()     // konstruktors
        {
            Cards = new List<Card>(); // mainigaja cards tiek izveidots jauns tukshu saraksts

        }
        public void GiveCard(Card card)    // konstroktoru izveido lai definetu noklusetas vertibas
        {
            Console.WriteLine("Spēlētajs saņēma kārti " +card.Suit + card.Value);
            Cards.Add(card);         // funkcija ievieto speletajam kartis roka

        }
        public int CountPoints()
        {
            int points = 0;
            int aceCount = 0;

            foreach(Card c in Cards)
            {
                points += c.GetValue();
                if (c.Value == "A")
                {
                    aceCount++; // palielina duza vertibu par viens
                }
            }

            while(points>21&& aceCount > 0)
            {
                points -= 10;             // samazinat punktu skaitu par desmit
                aceCount--;              // samazina duzu skaitu
            }

            return points;
        }
        public bool NeedAnotherCard()
        {
            var answer = Game.GetAnswer("Vai nepieciešama kārts?");

            return answer;
        }
    }
}
