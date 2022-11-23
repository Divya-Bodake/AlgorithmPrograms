using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BubbleSort
    {
        public void Sort(int[] binaryarr)
        {
            for (int i = 0; i < binaryarr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (binaryarr[i].CompareTo(binaryarr[j]) < 0)
                    {
                        int temp = binaryarr[j];
                        binaryarr[j] = binaryarr[i];
                        binaryarr[i] = temp;
                    }
                }
            }
            foreach (var data in binaryarr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
