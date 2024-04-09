namespace BrainGames.Code.Games
{
    public class Prime
    {
        public static void Start()
        {
            string ruleMessage = "Answer 'yes' if given number is prime. Otherwise answer 'no'.";
            List<Dictionary<string, string>> gameDataCollection = new(Engine.MAX_SUCCESSES_COUNT);
            for (int i = 0; i < Engine.MAX_SUCCESSES_COUNT; i++)
            {
                int currentRnd = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                string question = currentRnd.ToString();
                string correctAnswer = IsPrime(currentRnd) ? "yes" : "no";
                Dictionary<string, string> gameData = new()
                {
                    { "question", question },
                    { "answer", correctAnswer }
                };
                gameDataCollection.Add(gameData);
            }
            Engine.Execute(ruleMessage, gameDataCollection);
        }

        private static bool IsPrime(int questNum)
        {
            if (questNum < 2)
            {
                return false;
            }
            for (int i = 2; i <= questNum / 2; i++)
            {
                if (questNum % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}