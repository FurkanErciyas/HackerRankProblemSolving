namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinus(arr);

            Console.ReadKey();
        }
        public static void PlusMinus(List<int> arr)
        {
            List<float> ratios = new() { 0, 0, 0 };

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    ratios[0]++;
                }
                else if (arr[i] < 0)
                {
                    ratios[1]++;
                }
                else
                {
                    ratios[2]++;
                }
            }
            foreach (int item in ratios)
            {
                Console.WriteLine($"{((float)item / arr.Count):F6}");
            }
        }
    }
}