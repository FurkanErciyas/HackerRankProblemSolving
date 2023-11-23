namespace AVeryBigSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = AVeryBigSum(ar);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static long AVeryBigSum(List<long> ar)
        {
            long total = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                total += ar[i];
            }
            return total;
        }
    }
}