namespace BrainGames.Code.Games
{
    public static class Calc
    {
        private static readonly String[] OPERATORS = ["-", "+", "*"];

        public static void Start()
        {
            String ruleMessage = "What is the result of the expression?";
            List<Dictionary<String, String>> gameDataCollection = new(Engine.MAX_SUCCESSES_COUNT);

            for (int i = 0; i < Engine.MAX_SUCCESSES_COUNT; i++)
            {
                Int32 leftOperand = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                Int32 rightOperand = Utils.GetRandomInt(Engine.MIN_RANDOM_INT, Engine.MAX_RANDOM_INT);
                String op = OPERATORS[Utils.GetRandomInt(0, OPERATORS.Length)];
                String question = $"{leftOperand} {op} {rightOperand}";
                String correctAnswer = ResolveEquation(leftOperand, rightOperand, op).ToString();
                Dictionary<String, String> gameData = new()
                {
                    { "question", question },
                    { "answer", correctAnswer }
                };
                gameDataCollection.Add(gameData);
            }
            Engine.Execute(ruleMessage, gameDataCollection);
        }

        private static Int32 ResolveEquation(Int32 leftOperand, Int32 rightOperand, String op)
        {
            Int32 result = op switch
            {
                "+" => leftOperand + rightOperand,
                "*" => leftOperand * rightOperand,
                "-" => leftOperand - rightOperand,
                _ => throw new Exception("Error occurs in Calc.resolveStatement(int, int, String) method."
                                        + $" @param int leftOperand = {leftOperand}"
                                        + $" @param int rightOperand = {rightOperand}"
                                        + $" @param String operator = {op}"
                                        + $" Unknown to resolve operator {op}"),
            };
            return result;
        }
        
    }
}