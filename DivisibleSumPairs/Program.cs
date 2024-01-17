using System.IO;

namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = DivisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            int divisible = 0;

            for (int i = 0; i < ar.Count(); i++)
            {
                for (int j = i + 1; j < ar.Count(); j++)
                {

                    if (ar[i] + ar[j] == k || (ar[i] + ar[j]) % k == 0)
                    {
                        divisible++;
                    }

                }
            }

            return divisible;
        }
    }
}
