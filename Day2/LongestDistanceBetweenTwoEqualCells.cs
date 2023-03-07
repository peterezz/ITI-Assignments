using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class LongestDistanceBetweenTwoEqualCells
    {
        int[] array;
        
        public LongestDistanceBetweenTwoEqualCells(string inputData)
        {
            string[] userInputArray = inputData.Split(' ');
            array = new int[userInputArray.Length];
            for(int i = 0; i < userInputArray.Length; i++)
            {
                array[i] = int.Parse(userInputArray[i]);
            }
        }
        public List<ResultSet> FindLongestDistance()
        {
            List<ResultSet> resultSet = new List<ResultSet>();


            for (int row = 0; row < array.Length; row++)
            {
                ResultSet? Searchresult = resultSet.Find(x => x.item == array[row]);
                if (Searchresult == null)
                {
                    resultSet.Add(new ResultSet
                    {
                        item = array[row],
                        initIndex = row,
                        lastIndex = Array.LastIndexOf(array, array[row])
                    });                
                }
            }
            return resultSet;
        }
        public void SearchArray(int key)
        {
            int FirstOccureance = Array.IndexOf(array,key);
            int LastOccureance = Array.LastIndexOf(array,key);
            if(FirstOccureance == -1)
                Console.WriteLine($"number: {key} not found.");
            else
                Console.WriteLine($"distance between the occureance of number:" +
                    $" {key} is: {LastOccureance - FirstOccureance -1}");      



        }
    }
}
