using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDevilPark
{
    public class Witches
    {
        public static void partI()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You walk up to a large rustic cabin with purple smog fuming from its chimney.\n");
            Console.ReadKey();

            Console.WriteLine("You hear cackling from inside as you open the door.\n");
            Console.ReadKey();

            Console.WriteLine("You walk into a  candle lit room and see three witches surrounding a large bubbling cauldron. \n");
            Console.ReadKey();

            Console.WriteLine("Behind them is a large wooden door. \n");
            Console.ReadKey();

            Console.WriteLine("The witches turn to you: \n");
            Console.ReadKey();

            if (Game.Inventory.Contains("Silver Chalice"))
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\"You have the Silver Chalice! Give it!!\"");
                Console.ReadKey();

                Game.Ending();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\"Return once when you find the right treasure to add to our brew!\"\n\n \"Bwahahahaha\"");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You walk back to the park map.\n");
                Console.ReadKey();

                Checkpoint.Map();
            }
        }
    }
}

