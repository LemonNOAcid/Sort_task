using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm
{
    public class Select_Sort
    {
        public void select(int[] Number)
        {//发现最小的数字直接挪至目标位置
            Console.WriteLine("我是选择");
            for (int i = 0; i < Number.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Number.Length; j++)
                {
                    if (Number[i] > Number[j])
                    {
                        min = j;
                    }
                    int temp = Number[i];
                    Number[i] = Number[min];
                    Number[min] = temp;
                }
            }
            for (int i = 0; i < Number.Length; i++)
            {
                Console.Write(Number[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
