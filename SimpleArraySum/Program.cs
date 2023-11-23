namespace SimpleArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = SimpleArraySum(ar);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static int SimpleArraySum(List<int> ar)
        {
            int total = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                total += ar[i];
            }
            return total;
        }
    }
}