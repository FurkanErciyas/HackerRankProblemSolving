﻿namespace AppleAndOrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            CountApplesAndOranges(s, t, a, b, apples, oranges);
        }
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int countApple = 0;
            int countOrange = 0;
            foreach (int apple in apples)
            {
                if (apple + a >= s && apple + a <= t)
                {
                    countApple += 1;
                }
            }
            foreach (int orange in oranges)
            {
                if (orange + b >= s && orange + b <= t)
                {
                    countOrange += 1;
                }
            }
            Console.WriteLine($"{countApple}\n{countOrange}");

            Console.ReadKey();
        }
    }

}
