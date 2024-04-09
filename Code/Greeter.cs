namespace BrainGames.Code
{
    public static class Greeter
    {
        public static void Greet()
        {
            Console.WriteLine("Welcome to the Brain Games!");
            Console.Write("May I have your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}