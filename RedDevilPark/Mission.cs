using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDevilPark
{
    class Mission
    {
        public static object Inventory { get; private set; }

        public static void partI()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("As you and Roderick apporach the huge steel tower, you see a sign:\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WARNING!This ride may have adverse effects on your health Turn back if you have any doubts.PROCEED AT YOUR OWN RISK!\"\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You see a man being escorted by paramedics from the ride. A crowd of people start to leave.\n");
            Console.ReadKey();

            Console.WriteLine("You and Roderick turn to one another, he is looking very pale.\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"So what do you think? It's not too late to turn back!\" \n");
            Console.Read();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Continue or go back to park map?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Continue \n\n2. Go back to the park map.\n");
            Console.Read();


            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Mission.partII();
                
            }

            if (input == "2")
            {
                Console.Clear();
                Checkpoint.Map();
            }
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("Please enter a choice");
            //    Console.Read();
            //    Console.Clear();
            //    Mission.choice();
            //}
        }
        public static void partII()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\"Don't be ridiculous! How scary can it be?\"");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You get to the front of the line and enter the ride.");
            Console.Read();
            Console.Read();

            Console.WriteLine("You get strapped in a giant space shuttle and it goes completely dark.\n");
            Console.Read();

            Console.WriteLine("Suddenly an alarm is blaring and sparks start flying from the console.\n");
            Console.Read();

            Console.WriteLine("The ride starts rumbling thunderously.Something doesn't seem right!\n");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Do you want to stay on or get off?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Stay on. \n\n2. Get off!\n");

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Mission.partIII();
            }
            if (input == "2")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You unbuckle your harness in a panic.\n");
                Console.ReadKey();

                Console.WriteLine("You open the door and run outside but the ride takes off just as you exit and the door.\n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You take a big fall and break your leg.\n");
                Console.ReadKey();

                GameOver.Over();
            }
        }
        public static void partIII()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You close your eyes and hope for the best, afterall this is just part of the ride, right?\n");
            Console.ReadKey();

            Console.WriteLine("You feel your stomach sink into your feet as the ride shoots upwards.\n");
            Console.ReadKey();

            Console.WriteLine("In an instant you find yourself weightlessly gazing over the vast world below. The people look like ants.\n");
            Console.Read();

            Console.WriteLine("You glance up at something sparkly - a jewel hanging from a steel beam above you... just out of reach.\n");
            Console.Read();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Unbuckle your harness and try to grab it?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Don't risk it. \n\n2. Go for it. \n");

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You decide to play it safe and keep yourself in one piece.\n");
                Console.ReadKey();

                Console.WriteLine("Before you have a chance to feel remorse the ride plummets rapidly. You're back on earth.\n");
                Console.ReadKey();

                Console.WriteLine("You walk back to the park map.\n");
                Console.ReadKey();

                Checkpoint.Map();
            }

            if (input == "2")
            {
                Console.Clear();
                Mission.partIV();
            }

        }
        public static void partIV()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"What do you think you're doing??\"\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Despite protesting screams from Roderick, you unbuckle your harness.\n");
            Console.ReadKey();

            Console.WriteLine("You quickly stand on your seat and make a grab for it!\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\"I got it!\"\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The ride jerks and you fall back into your seat.\n");
            Console.ReadKey();

            Console.WriteLine("You quickly buckle up and the ride plummets!\n");
            Console.ReadKey();

            Console.WriteLine("Suddenly you're back on earth.\n");
            Console.ReadKey();

            Console.WriteLine("You look into your palm.\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You found the Ruby Key!\n");
            Console.ReadKey();

            //Add Ruby Key to inventory
            Game.Inventory.Add("Ruby Key");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You walk back to the park map.\n");
            Console.Read();

            Checkpoint.Map();
        }
    }
}
