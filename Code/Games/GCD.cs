namespace BrainGames.Code.Games
{
    public static class GCD
    {
        public static void Start()
        {
            string ruleMessage = "Find the greatest common divisor of given numbers.";
            List<Dictionary<string, string>> gameDataCollection = new(Engine.MAX_SUCCESSES_COUNT);

            for (int i = 0; i < Engine.MAX_SUCCESSES_COUNT; i++)
            {
                int leftOperand = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                int rightOperand = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                string question = $"{leftOperand} {rightOperand}";
                string correctAnswer = GetAnswer(leftOperand, rightOperand);
                Dictionary<string, string> gameData = new()
                {
                    { "question", question },
                    { "answer", correctAnswer }
                };
                gameDataCollection.Add(gameData);
            }
            Engine.Execute(ruleMessage, gameDataCollection);
        }

        private static string GetAnswer(int leftOperand, int rightOperand)
        {
            int greaterOperand = Math.Max(leftOperand, rightOperand);
            int lessOperand = Math.Min(leftOperand, rightOperand);

            while (lessOperand != 0)
            {
                int temp = greaterOperand % lessOperand;
                greaterOperand = lessOperand;
                lessOperand = temp;
            }
            return greaterOperand.ToString();
        }
    }
}