using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public static class MyExtentions
    {
        /// <summary>
        /// this function uses buble sort algorithm
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<int> SortArray(this List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int y = 0 ; y < list.Count; y++)
                {
                    if (list[y] < list[i])
                    {
                        (list[i], list[y]) = (list[y], list[i]);
                        
                    }
                }
            }
            return list;
        }
    }
}
