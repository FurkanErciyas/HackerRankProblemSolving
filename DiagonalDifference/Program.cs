namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference(arr);

            Console.WriteLine("Difference: " + result);

            Console.ReadKey();
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        primaryDiagonal += arr[i][j];
                    }
                    if (i + j == arr.Count - 1)
                    {
                        secondDiagonal += arr[i][j];
                    }
                }
            }

            return Math.Abs(primaryDiagonal - secondDiagonal);
        }
    }
}