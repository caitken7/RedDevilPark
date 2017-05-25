using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDevilPark
{
    public class Lucifer
    {
        public static void partI()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("As you approach, the drawbridge opens to greet you.\n");
            Console.ReadKey();

            Console.WriteLine("You and Roderick walk through the drawbridge and over the moat.\n");
            Console.ReadKey();

            Console.WriteLine("The carnival lights fade away behind you.\n");
            Console.ReadKey();

            Console.WriteLine("You walk through the castle doors and find yourself in a big dark room with two large doors.\n");
            Console.ReadKey();

            Console.WriteLine("The door on the left has ancient hieroglyhphs above it.\n");
            Console.ReadKey();

            Console.WriteLine("The door on the right is shaped like a coffin.\n");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which door would you like to go through?\n");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Left \n\n2. Right\n");
            Console.Read();

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Mummy.partI();
            }
            if (input == "2")
            {
                Console.Clear();
                Dracula.partI();
            }
        }
    }
}
