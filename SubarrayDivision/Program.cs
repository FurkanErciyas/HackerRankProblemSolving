using System.IO;

namespace SubarrayDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Birthday(s, d, m);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static int Birthday(List<int> s, int d, int m)
        {
            int numberOfWays = 0;

            for (int i = 0; i < s.Count(); i++)
            {
                if (s.Skip(i).Take(m).Sum() == d)
                {
                    numberOfWays++;
                }
            }

            return numberOfWays;
        }
    }
}
