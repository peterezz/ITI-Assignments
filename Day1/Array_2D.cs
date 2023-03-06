using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Array_2D
    {

        int[] sum = new int[3];
        int[,] array;
        public Array_2D()
        {
            array = new int[3, 4]
            {
                {30,80,60,70 },
                {50,60,80,100 },
                {50,150,200,30 }
            };
        }
        public int[] GetRowSum()
        {


            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                    sum[i]+= array[i,j];
            }
            return sum;
        }

        public double[] GetColAverage()
        {
            double[] avr =new double[4];
            for(int row = 0; row < array.GetLength(0); row++)
            {
                for(int col = 0; col < array.GetLength(1); col++)
                    avr[col]+=array[row,col];
            }
            for(int avrNum =0;avrNum<avr.Length;avrNum++)
                avr[avrNum] /= array.GetLength(0);
            return avr;
        }
    }
}
