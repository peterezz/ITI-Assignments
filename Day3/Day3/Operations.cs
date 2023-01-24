using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public static class Operations
    {
        internal static double Devide(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
                return firstNumber / secondNumber;
            else return 0;
        }

        internal static int Product(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        internal static int Subtract(int firstNumber, int secondNumber)
        {
            return   firstNumber - secondNumber;
        }

        internal static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
