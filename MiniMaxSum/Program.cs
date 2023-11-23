namespace MiniMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            MiniMaxSum(arr);
        }

        public static void MiniMaxSum(List<int> arr)
        {
            int minValue = arr[0], maxValue = arr[0];
            long sum = 0;

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"{sum - maxValue} {sum - minValue}");

        }
    }
}