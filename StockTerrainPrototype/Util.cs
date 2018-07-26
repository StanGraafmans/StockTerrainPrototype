using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTerrainPrototype
{
    public static class Util
    {
        public static int GetElementSum(int[] array, int from, int to)
        {
            int sum = 0;

            for (int i = from; i < to; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
