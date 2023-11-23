namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = TimeConversion(s);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static string TimeConversion(string? s)
        {
            DateTime newTime = DateTime.Parse(s);

            return newTime.ToLongTimeString();
        }
    }
}