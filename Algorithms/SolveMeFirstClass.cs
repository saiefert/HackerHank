using System;

namespace HackerRank.Algorithms
{
    public class SolveMeFirstClass
    {
        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }

        public void MainMethod()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
       
    }
}
