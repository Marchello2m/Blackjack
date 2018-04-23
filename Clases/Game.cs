using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Clases
{
   public class Game
    {
        public Dealer Dealer;
        public Player Player;
        public Deck;

        public bool StartNewGame()
        {
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli?");

            if (startNew)
            {
                Console.WriteLine("Uzsākta jauna spēle!");
                Deck = new Deck();
                Dealer = new Dealer();
                Player = new Player();
            }
            return startNew;


        }

        public static bool GetAnswer(string question)
        {

            Console.WriteLine(question +" (jā/nē)? ");
            string atbilde = Console.ReadLine().ToLower();
            bool answer = atbilde == "jā";
            return answer;
        }
    }
}
