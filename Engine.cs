namespace BrainGames.Code
{
    public static class Engine
    {
        public const Int32 MAX_RANDOM_INT = 100;
        public const Int32 MIN_RANDOM_INT = 0;
        public const Int32 MAX_SUCCESSES_COUNT = 3;

        internal static void Execute(String gameRule, List<Dictionary<String, String>> gameDataCollection)
        {
            Console.WriteLine("Welcome to the Brain Games!");
            Console.Write("May I have your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            Int32 currentSuccessesCount = 0;
            Console.WriteLine(gameRule);

            foreach (Dictionary<String, String> entry in gameDataCollection)
            {
                Console.WriteLine($"Question: {entry["question"]}");
                Console.Write("Your answer: ");
                String? suggestion = Console.ReadLine();

                if (suggestion.Equals(entry["answer"]))
                {
                    Console.WriteLine("Correct!");
                    currentSuccessesCount++;
                }
                else
                {
                    String outputAnswer = entry["answer"];
                    if (entry["answer"].Equals("yes") || entry["answer"].Equals("no"))
                    {
                        outputAnswer = $"'{entry["answer"]}'";
                    }
                    Console.WriteLine($"'{suggestion}' is wrong answer ;(. Correct answer was {outputAnswer}");
                    Console.WriteLine($"Let's try again, {name}!");
                    return;
                }
            }
            if (currentSuccessesCount == MAX_SUCCESSES_COUNT)
            {
                Console.WriteLine($"Congratulations, {name}!");
            }
        }
    }
}