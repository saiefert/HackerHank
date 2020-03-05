using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms
{
    public class CompareTheTripletsClass
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int one = 0, two = 0;
            var list = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i]) one += 1;
                if (a[i] < b[i]) two += 1;
            }

            list.Add(one);
            list.Add(two);

            return list;
        }

        public void Imprimir()
        {

        }

        public void MainMethod()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
