namespace BrainGames.Code.Games
{
    public class Progression
    {
        private const int PROGRESSION_LENGTH = 10;
        public static void Start()
        {
            string ruleMessage = "What number is missing in the progression?";
            List<Dictionary<string, string>> gameDataCollection = new(Engine.MAX_SUCCESSES_COUNT);

            for (int i = 0; i < Engine.MAX_SUCCESSES_COUNT; i++)
            {
                int progressionIncrement = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                int progressionStartValue = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                int missingValuePosition = Utils.GetRandomInt(0, PROGRESSION_LENGTH);
                string[] progressArr =
                        GetQuestion(progressionStartValue, progressionIncrement, PROGRESSION_LENGTH);
                progressArr[missingValuePosition] = "..";
                string question = string.Join(" ", progressArr);
                int solution = progressionStartValue + missingValuePosition * progressionIncrement;
                string correctAnswer = solution.ToString();
                Dictionary<string, string> gameData = new()
                {
                    { "question", question },
                    { "answer", correctAnswer }
                };
                gameDataCollection.Add(gameData);
            }
            Engine.Execute(ruleMessage, gameDataCollection);
        }

        private static string[] GetQuestion(int start, int increment, int progressionLength)
        {
            string[] result = new string[progressionLength];
            for (int i = 0; i < progressionLength; i++)
            {
                result[i] = start.ToString();
                start += increment;
            }
            return result;
        }
    }
}