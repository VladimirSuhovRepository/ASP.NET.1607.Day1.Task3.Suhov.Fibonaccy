using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day1.Task3.Suhov
{
    public static class CalculationFibonacci
    {
        /// <summary>Calculates n-number in Fibonacci sequence</summary> 
        /// <param name="value">Number which should be calculated</param> 
        /// <returns>The number <paramref name="n"/> in Fibonaccy sequence is <paramref name="value"/></returns> 
        public static int Calculate(int n)
        {
            int first = 1;
            int second = 1;
            int result = 0;
            switch (n)
            {
                case 0: return 0;
                case 1: return first;
                case 2: return second;
            }
            for (int i = 1; i <= n - 2; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            return result;
        }
    }
}
