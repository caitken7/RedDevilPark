using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDevilPark
{
    public class Mummy
    {
        public static void partI()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("You and Roderick walk through the door on the left and descend a spiraling stone stairwell lit with torches.\n");
            Console.ReadKey();

            Console.WriteLine("At the base is a maze of hieroglyph covered walls and sand covering the floors.\n");
            Console.ReadKey();

            Console.WriteLine("The two of you begin wandering through the dimly lit narrow corridors, and soon become lost.\n");
            Console.ReadKey();

            Console.WriteLine("Suddenly you hear screaming from a distance.\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Investigate it or go the opposite way?\n");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. \"Someone must be in trouble!\" \n\n2. \"Let's get out of here!\"\n");

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Mummy.partII();
            }

            if (input == "2")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You run through a dark corridor and fall in quicksand!\n");
                Console.ReadKey();

                Console.WriteLine("The pit swallows you and a few seconds later, shoots you out into the castle moat.\n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Later you drive back home soaking wet and smelling like algae.\n");
                Console.ReadKey();

                GameOver.Over();
            }
        }

        public static void partII()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("The two of you run heroically towards the screams and encounter a frantic group of people.\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Run! The giant mechanical Mummy is malfunctioning! It's on a blood-thirsty rampage!\"\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You and Roderick look each other dead in the eye.\n");
            Console.Read();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Run or fight the Mummy?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Run. \n\n2. Fight the Mummy.\n");
            Console.Read();

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You turn to run and accidentally trip over a pile of sand stones. You fall to the ground.\n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You wake up the next day in the hospital with a mild concussion.\n");
                Console.ReadKey();

                GameOver.Over();
            }
            if (input == "2")
            {
                Console.Clear();
                Mummy.partIII();
            }
        }
        public static void partIII()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("You and Roderick walk in the direction the group came from.\n");
            Console.ReadKey();

            Console.WriteLine("Suddenly the stone wall ahead of you shakes violently - The Mummy bursts through with its fists!\n");
            Console.ReadKey();

            Console.WriteLine("You notice the mummy's head already looks damaged, also there are exposed wires hanging from its rear chassis. \n");
            Console.ReadKey();

            Console.WriteLine("You look around for a weapon but only see stones. \n");
            Console.Read();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Throw stones at its head or attempt to remove its wiring?\n");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Throw stones at its head. \n\n2. Attempt to remove its wiring.\n");
            Console.Read();

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                Mummy.partIV();
            }
            if (input == "2")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("You sprint towards the mummy and slide through its legs as it lethargically swings at you with its massive arm. \n");
                Console.ReadKey();

                Console.WriteLine("You reach up and yank the exposed wiring. \n");
                Console.ReadKey();

                Console.WriteLine("The Mummy shuts down and its lifeless mechanical body falls to the ground. \n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You jump to escape it but it falls on your leg, pinning you. \n");
                Console.ReadKey();
                
                Console.WriteLine("Paramedics eventually arrive and escort you to the hospital. \n");
                Console.ReadKey();

                GameOver.Over();
            }
        }
        public static void partIV()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You and Roderick start chucking rocks at the Mummy hoping to land a blow.\n");
            Console.ReadKey();

            Console.WriteLine("You hurl a cantalope sized rock through the air like an olympic shotputter...\n");
            Console.ReadKey();

            Console.WriteLine("...and hit him right between the eyes! His mechanical body falls to the ground! \n");
            Console.ReadKey();

            Console.WriteLine("Standing over his lifeless body you see a glowing green object in its eye.\n");
            Console.ReadKey();

            Console.WriteLine("You reach in to grab it...\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You found the Emerald Scarab!\n");
            Console.Read();

            //Add Emerald Scarab to inventory
            Game.Inventory.Add("Emerald Scarab");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Go back upstairs to the coffin shaped door, or go back to the park map?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Go back to the coffin shaped door. \n\n2. Go back to the park map.\n");
            Console.Read();

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Dracula.partI();
            }

            if (input == "2")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You walk back to the park map.\n");
                Console.Read();

                Checkpoint.Map();
            }
        }
    }
}
