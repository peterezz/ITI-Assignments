using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public static class Operations
    {
        public static double Devide(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
                return firstNumber / secondNumber;
            else return 0;
        }

        public static int Product(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
