using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public class AVeryBigSumClass
    {
        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long bigSum = 0;
            
            foreach (var item in ar)
            {
                bigSum += item;
            }

            return bigSum;
        }

    }
}
