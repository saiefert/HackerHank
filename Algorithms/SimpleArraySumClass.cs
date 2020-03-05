using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Algorithms
{
    public class SimpleArraySumClass
    {
        /*
     * Complete the simpleArraySum function below.
     */
        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (var n in ar)
            {
                sum += n;
            }

            return sum;

        }

        public void MainMethod()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
