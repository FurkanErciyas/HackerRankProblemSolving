namespace BreakingTheRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = BreakingRecords(scores);

            Console.WriteLine(String.Join(" ", result));

            Console.ReadKey();
        }

        private static List<int> BreakingRecords(List<int> scores)
        {
            List<int> recordList = new List<int>() { 0, 0 };
            List<int> lowestScore = new List<int>() { scores[0] };
            List<int> highestScore = new List<int>() { scores[0] };

            for (int i = 1; i <= scores.Count() - 1; i++)
            {
                if (scores[i] >= highestScore[i - 1])
                {
                    highestScore.Add(scores[i]);
                    lowestScore.Add(lowestScore[i - 1]);
                }
                else if (scores[i] <= lowestScore[i - 1])
                {
                    highestScore.Add(highestScore[i - 1]);
                    lowestScore.Add(scores[i]);
                }
                else
                {
                    highestScore.Add(highestScore[i - 1]);
                    lowestScore.Add(lowestScore[i - 1]);
                }

                if (highestScore[i] > highestScore[i - 1])
                {
                    recordList[0]++;
                }

                if (lowestScore[i] < lowestScore[i - 1])
                {
                    recordList[1]++;
                }
            }

            return recordList;
        }
    }
}
