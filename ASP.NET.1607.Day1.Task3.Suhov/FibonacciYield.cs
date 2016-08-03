using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day1.Task3.Suhov
{
    public class FibonacciYield:IEnumerable
    {
        #region Private Fields
        private int[] _fibonacci;
        private int firstNumber = 1;
        private int secondNumber = 1;
        #endregion
        /// <summary>
        /// Default constructor without parameters
        /// </summary>
        public FibonacciYield() { }
        /// <summary>
        /// Constructor with parameter number of items
        /// </summary>
        public FibonacciYield(int numbersCount)
        {
            _fibonacci = new int[numbersCount];
            for (int i = 0; i < _fibonacci.Length; i++)
            {
                _fibonacci[i] = GetNextNumber(i);
            }
        }
        /// <summary>
        /// Implemented IEnumerable inferface method
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _fibonacci.Length; i++)
            {
                yield return _fibonacci[i];
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
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            return result;
        }
        #endregion
    }
}
