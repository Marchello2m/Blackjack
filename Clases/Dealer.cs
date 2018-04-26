using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Clases
{
   public class Dealer: Player       // clase dealer manto klasi player
                                      // vis parejais paliek ka bija
    {
        public override void GiveCard(Card card)
        {
            Cards.Add(card);
        }

        public void GiveCard(Card card,bool showeCard)
        {
            Cards.Add(card);
            if (showeCard)
            {
                Console.WriteLine("Dīleris saņēma"+ card.Suit + card.Value);
            }
        }

        public override bool NeedAnotherCard()
        {
            return CountPoints() < 17;
        }


    }
}
