using BrainGames.Code;
using BrainGames.Code.Games;

namespace BrainGames
{
    public static class App
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter the game number and press Enter key.");
            Console.WriteLine("1 - Greet\n2 - Even\n3 - Calc\n4 - GCD\n5 - Progression\n6 - Prime\n0 - Exit\n");

            String? choice = Console.ReadLine();
            GameSwitch(choice);
        }

        private static void GameSwitch(String? choice)
        {
            switch (choice)
            {
                case "1":
                    Greeter.Greet();
                    break;
                case "2":
                    Even.Start();
                    break;
                case "3":
                    Calc.Start();
                    break;
                case "4":
                    GCD.Start();
                    break;
                case "5":
                    Progression.Start();
                    break;
                case "6":
                    Prime.Start();
                    break;
                default:
                    break;
            }
        }
    }
}