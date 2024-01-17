namespace NumberLineJumps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = Kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {

            int firstDifference = Math.Abs(x1 - x2);
            int secondDifference = Math.Abs((x1 + v1) - (x2 + v2));

            if (secondDifference >= firstDifference)
            {
                return "NO";
            }
            else
            {
                int jumps = (-(x1 - x2)) / (v1 - v2);

                if (x1 + jumps * v1 == x2 + jumps * v2) 
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
        }
    }
}
