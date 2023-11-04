using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EgovtsevMN.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;  
            int columns = array.Length / rows;  
            int count = array[0, 2];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    if (array[i, 2] < count)
                    {
                        count = array[i, 2];
                    }
                }
            }
            return count;
        }
    }
}
