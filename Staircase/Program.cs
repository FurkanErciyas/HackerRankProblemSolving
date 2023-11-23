namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Staircase(n);

            Console.ReadKey();
        }

        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', (n - i)) + new string('#', i));
            }
        }
    }
}