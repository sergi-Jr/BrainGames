namespace BrainGames.Code.Games
{
    public static class Even
    {
        public static void Start()
        {
            String ruleMessage = "Answer 'yes' if the number is even, otherwise answer 'no'.";
            List<Dictionary<String, String>> gameDataCollection = new(Engine.MAX_SUCCESSES_COUNT);

            for (int i = 0; i < Engine.MAX_SUCCESSES_COUNT;  i++)
            {
                Int32 questionNum = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                String question = questionNum.ToString();
                String answer = IsEven(questionNum) ? "yes" : "no";
                Dictionary<String, String> gameData = [];
                gameData.Add("question", question);
                gameData.Add("answer", answer);
                gameDataCollection.Add(gameData);
            }
            Engine.Execute(ruleMessage, gameDataCollection);
        }

        private static Boolean IsEven(Int32 statement)
        {
            return statement % 2 == 0;
        }
    }
}