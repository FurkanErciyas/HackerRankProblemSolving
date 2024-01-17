using System.IO;

namespace MigratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MigratoryBirds(arr);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static int MigratoryBirds(List<int> arr)
        {
            Dictionary<int, int> typeList = new Dictionary<int, int>() { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };

            foreach (var type in arr)
            {
                switch (type)
                {
                    case 1: typeList[1]++; break;
                    case 2: typeList[2]++; break;
                    case 3: typeList[3]++; break;
                    case 4: typeList[4]++; break;
                    case 5: typeList[5]++; break;
                }
            }

            int maxtype = typeList.ElementAt(0).Key;
            for (int i = 0; i < typeList.Count; i++)
            {
                if (typeList.ElementAt(i).Value > typeList[maxtype])
                {
                    maxtype = typeList.ElementAt(i).Key;
                }
            }

            return maxtype;
        }
    }
}
