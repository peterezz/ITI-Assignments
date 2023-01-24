using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public static class Swapping
    {
        public static void swapByValue(int x,int y)
        {
           (x,y)=(y,x);
          //  Console.WriteLine($"Value of first element: {x} - value of second element: {y}");
        }
        public static void SwapByRefrance(ref int x,ref int y)
        {
            (x, y) = (y, x);
        }
    }
}
