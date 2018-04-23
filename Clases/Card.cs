using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Clases
{
   public class Card
    {
      
            public string Value;
        public char Suit;

        public Card(string value,char suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        public int GetValue()
        {
            switch (Value)
            {
                case "A":
                    return 11;
                case "J":
                case "Q":
                case "K":                            // visi nestandarta gadijumi parejos var convertet
                    return 10;
                default:
                    return Convert.ToInt32(Value);// nolasis parejos
            }
            
        }


        

    }
}
