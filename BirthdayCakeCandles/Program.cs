namespace BirthdayCakeCandles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = BirthdayCakeCandles(candles);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static int BirthdayCakeCandles(List<int> candles)
        {
            int heightCandles = candles[0], heightCandlesCount = 1;

            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] > heightCandles)
                {
                    heightCandles = candles[i];
                    heightCandlesCount = 1;
                }
                else if (candles[i] == heightCandles)
                {
                    heightCandlesCount++;
                }
            }
            return heightCandlesCount;
        }
    }
}