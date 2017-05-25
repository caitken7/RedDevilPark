using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDevilPark
{
    public class Dracula
    {
        public static void partI()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("You walk through the coffin shaped door and begin ascending a tall spiraling staircase lit with candles.\n");
            Console.ReadKey();

            Console.WriteLine("At the top of the stairs is a dark room. There are hundreds of little red eyes staring at you from the ceiling. \n");
            Console.ReadKey();

            Console.WriteLine("There is a door in front of you with a sign: \n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Dracula's Chamber.\"\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("There's also a utility door on the adjacent wall with a sign: \n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Authorized personell only.\"\n");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Go to Dracula's Chamber or through Utility Door?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Dracula's Chamber \n\n2. Utility Door\n");
            Console.Read();

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Dracula.partII();
            }

            if (input == "2")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You go through the utility door and it shuts behind you.\n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\"Nothing in here but junk and electrical equipment.\" \n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You turn to leave but the door is locked. \n");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You wait hours before a worker lets you out.\n");
                Console.ReadKey();

                GameOver.Over();
            }
        }

        public static void partII()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("You quietly walk through the door into a cold, dark room filled with Transylvanian decor. \n");
            Console.ReadKey();

            Console.WriteLine("Ahead of you is a large black coffin closed shut. \n");
            Console.ReadKey();

            Console.WriteLine("In front of the coffin is a pedestal with a strange box on it. \n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"There must be something in the box!\"\n");
            Console.ReadKey();

            Console.WriteLine("\"Or maybe there's something in the coffin!\"\n");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Open the box or the coffin?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Open the strange box. \n\n2. Open the coffin.\n");
            Console.Read();

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                Dracula.partV();
            }
            if (input == "2")
            {
                Console.Clear();
                Dracula.partIII();
            }
        }
        public static void partIII()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("You and Roderick use all your might to pry the coffin door open. \n");
            Console.ReadKey();

            Console.WriteLine("Inside you look up at a 7 foot tall Dracula with arms crossed. He appears to be resting. \n");
            Console.ReadKey();

            Console.WriteLine("He seems to be holding something in his hands... \n");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Attempt to grab it or try opening the strange box?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Grab the item from Dracula's hands. \n\n2. Open the strange box.\n");
            Console.Read();

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                Dracula.partIV();
            }
            if (input == "2")
            {
                Console.Clear();

                Dracula.partV();
            }
        }
        public static void partIV()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You slowly reach for the object as sweat beads down your forehead...\n");
            Console.ReadKey();

            Console.WriteLine("You reach up to grab it...\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\"Got it!\"\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You found the Blood Sapphire!\n");
            Console.Read();

            //Add Blood Sapphire to inventory
            Game.Inventory.Add("Blood Sapphire");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You softly close the coffin. That was surprisingly easy!\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Go back downstairs to the hieroglyph door, or go back to the park map?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Go back to the hieroglyph door. \n\n2. Go back to the park map.\n");
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
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nYou walk back to the park map.\n");
                Console.Read();

                Console.Clear();

                Checkpoint.Map();
            }
        }
        public static void partV()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You open the box and hear a sinister laugh... \n");
            Console.ReadKey();

            Console.WriteLine("Suddenly a trap door opens under your feet, swallowing both of you! \n");
            Console.ReadKey();

            Console.WriteLine("You slide through a tube and it shoots you out into the castle moat. \n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have to drive back home in your wet clothes, smelling like fish.\n");
            Console.ReadKey();

            GameOver.Over();
        }
    }
}
