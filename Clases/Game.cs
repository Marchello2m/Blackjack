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
        public Deck Deck;

        public bool StartNewGame()
        {
            bool startNew = Game.GetAnswer("Vai uzsākt jaunu spēli?");

            if (startNew)
            {
                Console.WriteLine("Uzsākta jauna spēle!");
                Deck = Deck.TakeNewDeck();
                Dealer = new Dealer();
                Player = new Player();

                Deck.Shuffle();
                Player.GiveCard(Deck.TakeCard());      // divas reizes lai speletajam iedotu karti
                Player.GiveCard(Deck.TakeCard());

                Dealer.GiveCard(Deck.TakeCard(),true);        // funkcija ar diviem parametriem
                Dealer.GiveCard(Deck.TakeCard());               // funkcija ar vineu


                while (Player.NeedAnotherCard())
                {
                    Player.GiveCard(Deck.TakeCard());
                }

                while (Dealer.NeedAnotherCard())
                {
                    Dealer.GiveCard(Deck.TakeCard());
                }
                CountPoints();
            }
            return startNew;


        }
        public void CountPoints()
        {
            int playerPoints = Player.CountPoints();
            int dealerPoints = Dealer.CountPoints();

            if(playerPoints> 21)
            {
                Console.WriteLine("Tu zaudēji!!");
            }
            else if (dealerPoints > 21)
            {
                Console.Write("Tu uzvarēji!");
            }
            else if (dealerPoints == playerPoints)
            {
                Console.WriteLine("Nav uzvarētāja!");
            }
            else if (playerPoints>dealerPoints)
            {
                Console.WriteLine("Tu uzvarēji!");
            }
            else
            {
                Console.WriteLine("Tu Zaudēji!");
            }
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
