using System.ComponentModel.Design;

namespace GradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingStudents(grades);

            Console.WriteLine(result);
            
            Console.ReadKey();
        }

        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> newGrades = new List<int>();

            foreach (int grade in grades)
            {
                if (grade >= 38)
                {
                    if ((grade + 2) % 5 == 0)
                    {
                        newGrades.Add(grade + 2);
                    }
                    else if ((grade + 1) % 5 == 0)
                    {
                        newGrades.Add(grade + 1);
                    }
                    else 
                    {
                        newGrades.Add(grade);
                    }
                }
                else
                {
                    newGrades.Add(grade);
                }
            }
            return newGrades;
        }
    }
}
