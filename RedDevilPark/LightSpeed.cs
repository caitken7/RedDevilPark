using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDevilPark
{
    public static class LightSpeed
    {
        public static void partI()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You climb inside the roller coaster and secure your harness.\n");
            Console.ReadKey();

            Console.WriteLine("The ride starts and begins climbing higher and higher. \n");
            Console.ReadKey();

            Console.WriteLine("Suddenly you plunge down and descend into a dark cave.  \n");
            Console.ReadKey();

            Console.WriteLine("The walls suddenly spring to life with colorful lights and lasers. \n");
            Console.ReadKey();

            Console.WriteLine("As you near the end of the ride it comes to a grinding halt at the top of a loop. \n");
            Console.ReadKey();

            Console.WriteLine("It seems you might be stuck here a while. \n");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wait for help or climb down?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Wait for help. \n\n2. Climb down.\n");
            Console.Read();


            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                LightSpeed.partII();
            }

            if (input == "2")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You get impatient and unbuckle your harness. \n");
                Console.ReadKey();

                Console.WriteLine("You climb like a monkey down the loop of the coaster track. \n");
                Console.ReadKey();

                Console.WriteLine("Suddenly the coaster starts moving again! \n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You let go in a panic and fall into some bushes, spraining your shoulder. \n");
                Console.ReadKey();

                GameOver.Over();
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You wait a few minutes and the ride resumes. \n");
            Console.ReadKey();

            Console.WriteLine("The ride returns to the beginning and you guys get off. \n");
            Console.ReadKey();

            //Game.Inventory.Add("Ruby Key");

            Console.WriteLine("As you walk off the ride, you notice a mysterious shed with a ruby door handle. \n");
            Console.Read();

            if (Game.Inventory.Contains("Ruby Key"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\"Maybe this will work!\"\n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You use the ruby key... \n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("...The door opens!\n");
                Console.ReadKey();
                
                Console.WriteLine("Inside you find a treasure chest. You open it...\n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You found the Silver Chalice!\n");
                Console.ReadKey();

                //Add Silver Chalice to inventory
                Game.Inventory.Add("Silver Chalice");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You walk back to the park map.\n");
                Console.ReadKey();

                Checkpoint.Map();

            }
            else
            {
                Console.WriteLine("Too bad you don't have a key for this door.\n");
                Console.ReadKey();

                Console.WriteLine("You walk back to the park map.\n");
                Console.ReadKey();

                Checkpoint.Map();
            }
        }
    }
}
