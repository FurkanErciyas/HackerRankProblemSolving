namespace BetweenTwoSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = GetTotalX(arr, brr);

            Console.WriteLine(total);

            Console.ReadKey();

        }

        public static int GetTotalX(List<int> a, List<int> b)
        {
            int result = 0;

            for (int i = a.Max(); i <= b.Min(); i++)
            {
                if (a.All(x => i % x == 0) && b.All(y => y % i == 0))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
