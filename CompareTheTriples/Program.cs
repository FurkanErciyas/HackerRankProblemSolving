namespace CompareTheTriples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();



            List<int> result = CompareTriples(a, b);

            Console.WriteLine($"{result[0]} {result[1]}");

            Console.ReadKey();

        }

        public static List<int> CompareTriples(List<int> a, List<int> b)
        {
            List<int> scores = new List<int>() { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    scores[0]++;
                }
                else if (a[i] < b[i])
                {
                    scores[1]++;
                }
            }

            return scores;
        }
    }
}