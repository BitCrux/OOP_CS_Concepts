using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------- random strings ---------------------------");
            Console.WriteLine();

            List<string> randomStrings = new List<string>();
            FillListWithRandomStrings(randomStrings, 10);

            randomStrings.ForEach((v) => Console.WriteLine(v));

            string toFindElement = randomStrings[5];
            Console.WriteLine($"Element to find is: {toFindElement}");
            Console.WriteLine();

            string strResult = randomStrings.Find((v) => v == toFindElement);
            Console.WriteLine($"Result of search is: {strResult}");
            Console.WriteLine();

            //string ElementExists = "123";
            string ElementExists = randomStrings[3];
            Console.WriteLine($"Element to check if it exists: {ElementExists}");
            Console.WriteLine();

            bool boolResult = randomStrings.Exists((v) => v == ElementExists);
            Console.WriteLine($"Element exists?: {boolResult}");
            Console.WriteLine();

            randomStrings.Sort();
            Console.WriteLine("Sorted list: ");
            randomStrings.ForEach((v) => Console.WriteLine(v));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("-------------------------- random numbers ---------------------------");
            Console.WriteLine();

            List<int> randomNumbers = new List<int>();
            FillListWithRandomNumbers(randomNumbers, 10);

            randomNumbers.ForEach((v) => Console.WriteLine(v));
            Console.WriteLine();

            randomNumbers.Sort((x, y) => y - x);
            Console.WriteLine("List sorted in descending order: ");
            randomNumbers.ForEach((v) => Console.WriteLine(v));
            Console.WriteLine();

            randomNumbers.Sort((x, y) => x - y);
            Console.WriteLine("List sorted in ascending order: ");
            randomNumbers.ForEach((v) => Console.WriteLine(v));
            Console.WriteLine();

            Console.ReadLine();
        }

        static public void FillListWithRandomStrings(List<string> list, int numberOfElements)
        {
            Random rand = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                char[] randomStr = new char[10];
                for (int j = 0; j < 10; j++)
                {
                    randomStr[j] = (char)rand.Next(65, 90);
                }
                list.Add(new String(randomStr));
            }
        }

        static public void FillListWithRandomNumbers(List<int> list, int numberOfElements)
        {
            Random rand = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                list.Add(rand.Next(0, 100));
            }
        }
    }
}
