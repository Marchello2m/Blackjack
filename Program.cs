using System;
using Blackjack.Clases;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {

       public static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
               if(!game.StartNewGame())
                {
                    break;
                }
            }
            Console.WriteLine("Spēle pabeigta!");
            Console.ReadLine();
        }
    }
}
