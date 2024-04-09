namespace BrainGames.Code
{
    public static class Utils
    {
        public static Int32 GetRandomInt(Int32 lowerBorder, Int32 upperBorder)
        {
            Random rnd = new();
            return rnd.Next(lowerBorder, upperBorder);
        }
    }
}
