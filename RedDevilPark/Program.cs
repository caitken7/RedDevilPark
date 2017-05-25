using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedDevilPark
{
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
        }
    }
    public class Game
    {
        public static List<string> Inventory = new List<string>();

        public static void StartGame()
        {


            GameTitle.Title();
            IntroScreen intro = new IntroScreen();
            intro.writeSentence();
            IntroScreen.NameCharacter();
            Checkpoint.Map();

            Game.Ending();

        }
        public static void Ending()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\rThe witches wave their broomsticks and the door behind them creaks open... You enter.\n");
            Console.ReadKey();

            Console.WriteLine("You see a treasure chest inside. You open it... \n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...You found the Golden Sceptre!\n");
            Console.ReadKey();

            //Add Golden Sceptre to inventory
            Game.Inventory.Add("Golden Sceptre");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You found these items on your journey: \n");

            foreach (string item in Inventory)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCongratulations!!");
            Console.ReadKey();

            Game.Inventory.Clear();
            Console.Clear();
        }
}
    
    public class GameTitle
    {
        public static string title = @"

 ██▀███  ▓█████ ▓█████▄    ▓█████▄ ▓█████ ██▒   █▓ ██▓ ██▓        ██▓███   ▄▄▄       ██▀███   ██ ▄█▀
▓██ ▒ ██▒▓█   ▀ ▒██▀ ██▌   ▒██▀ ██▌▓█   ▀▓██░   █▒▓██▒▓██▒       ▓██░  ██▒▒████▄    ▓██ ▒ ██▒ ██▄█▒ 
▓██ ░▄█ ▒▒███   ░██   █▌   ░██   █▌▒███   ▓██  █▒░▒██▒▒██░       ▓██░ ██▓▒▒██  ▀█▄  ▓██ ░▄█ ▒▓███▄░ 
▒██▀▀█▄  ▒▓█  ▄ ░▓█▄   ▌   ░▓█▄   ▌▒▓█  ▄  ▒██ █░░░██░▒██░       ▒██▄█▓▒ ▒░██▄▄▄▄██ ▒██▀▀█▄  ▓██ █▄ 
░██▓ ▒██▒░▒████▒░▒████▓    ░▒████▓ ░▒████▒  ▒▀█░  ░██░░██████▒   ▒██▒ ░  ░ ▓█   ▓██▒░██▓ ▒██▒▒██▒ █▄
░ ▒▓ ░▒▓░░░ ▒░ ░ ▒▒▓  ▒     ▒▒▓  ▒ ░░ ▒░ ░  ░ ▐░  ░▓  ░ ▒░▓  ░   ▒▓▒░ ░  ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░▒ ▒▒ ▓▒
░▒ ░ ▒░ ░ ░  ░ ░ ▒  ▒     ░ ▒  ▒  ░ ░  ░  ░ ░░   ▒ ░░ ░ ▒  ░   ░▒ ░       ▒   ▒▒ ░  ░▒ ░ ▒░░ ░▒ ▒░
░░   ░    ░    ░ ░  ░     ░ ░  ░    ░       ░░   ▒ ░  ░ ░      ░░         ░   ▒     ░░   ░ ░ ░░ ░ 
░        ░  ░   ░          ░       ░  ░     ░   ░      ░  ░                  ░  ░   ░     ░  ░   
                ░          ░                 ░                                                     

                                                                                                                ";
        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Utility.center(title);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to start");

            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public static class GameOver
    {

        public static void Over()
        {
            Console.Clear();
            string overtitle = @"
 ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ 
██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗
██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝
 
";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(overtitle);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to restart from checkpoint.");
            Console.ReadKey();

            Console.Clear();
            Checkpoint.Map();
        }
    }

    public class IntroScreen
    {
        private string Sentence;
        private static Random myRandom = new Random();


        public IntroScreen()
        {
            this.Sentence = getSentence();
        }

        public string getSentence()
        {
            string[] nameList = new String[] { "A dark cloud hangs overhead.", "A cold breeze raises the hair on your neck.", "The shadows are calling." };
            return nameList[getRandomNumber(nameList.Length)];
        }

        private int getRandomNumber(int range)
        {
            return myRandom.Next(range);
        }

        public void writeSentence()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tonight is the grand opening of Red Devil Amusement Park..." + Sentence);
            Console.Read();
            Console.Clear();
        }
        
        public static void NameCharacter()
        {
            String CharacterName = "";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your name?\n");
            Console.Read();
            Console.ForegroundColor = ConsoleColor.Green;
            CharacterName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWelcome " + CharacterName + ".");
            Console.Read();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Yo " + CharacterName + ", I see the park up ahead!\" says your buddy Roderick.\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The two of you arrive at Red Devil Park, a mysterious carnival unlike any other... \n");
            Console.ReadKey();

            Console.WriteLine("You walk through the large rusted gates surrounded by gargoyles. There's a sign: \n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\"Tonight only... Somewhere in the park is a Golden Sceptre waiting to be found...\n\nOnly one lucky individual will find it.\"\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You continue walking until you reach the park map... \n");
            Console.ReadKey();

            Checkpoint.Map();
        }
    }

    public class Checkpoint
    {
        public static void Map()
        {
            Console.Clear();
            string[] location = new string[4]
            {
            "Mission to Mars", "Lucifer's Castle", "Light Speed", "The Witches' Cauldron"
            };


            foreach (string item in Game.Inventory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Where would you like to go?\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. " + location[0] + "\n2. " + location[1] + "\n3. " + location[2] + "\n4. " + location[3] + "\n");

            string input = "";
            Console.ForegroundColor = ConsoleColor.Green;
            input = Console.ReadLine();


            if (input.ToLower() == "1")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You chose Mission to Mars!\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A vertical drop ride housed in a 200 - foot tall steel tower.\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter 1 to continue or 2 to go back\n");

                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    Mission.partI();
                }

                else
                {
                    Console.Clear();
                    Map();
                }
            }

            if (input.ToLower() == "2")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You chose Lucifer's Castle!\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("An authentic medieval castle complete with a drawbridge, walls, towers, flying pennants, and a moat.\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter 1 to continue or 2 to go back");

                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    Lucifer.partI();
                }

                else
                {
                    Console.Clear();
                    Map();
                }
            }

            if (input.ToLower() == "3")
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You chose Light Speed!\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The park's biggest roller coaster.\nYou must take tram across the park to get there.\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter 1 to continue or 2 to go back");

                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    LightSpeed.partI();
                }

                else
                {
                    Console.Clear();
                    Map();
                }

            }
            if (input.ToLower() == "4")
            {
                Console.Clear();

                Witches.partI();
            }
            else
            {
                //Console.WriteLine("Please enter one of the choices.");
                //Console.Read();
                //Console.Clear();
                Map();
            }
        }
    }
    public class Utility
    {
        internal static void center(string title)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = title.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);

            Console.WriteLine(title.PadLeft(spaces));
        }

    }
}

