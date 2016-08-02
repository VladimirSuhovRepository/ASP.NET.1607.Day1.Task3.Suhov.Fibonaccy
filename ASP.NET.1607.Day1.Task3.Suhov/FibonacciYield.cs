using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day1.Task3.Suhov
{
    public class FibonacciYield
    {
        #region Private Fields
        private int[] _fibonacci;
        private int firstNumber = 1;
        private int secondNumber = 1;
        #endregion
        public FibonacciYield() { }
        public FibonacciYield(int numbersCount)
        {
            _fibonacci = new int[numbersCount];
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _fibonacci.Length; i++)
            {
                int iterator = GetNextNumber(i);
                yield return iterator;
            }
        }
        #region Private Methods
        private int GetNextNumber(int num)
        {
            int result = 0;
            switch (num)
            {
                case 0: return 0;
                case 1: return firstNumber;
                case 2: return secondNumber;
            }
            for (int i = 1; i <= num - 3; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            return result;
        }
        #endregion
    }
}
