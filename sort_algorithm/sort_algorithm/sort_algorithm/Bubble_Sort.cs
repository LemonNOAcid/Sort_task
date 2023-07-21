using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm
{
    public class Bubble_Sort
    {
        public void bubble(int[] Number)
        {
            Console.WriteLine("我是冒泡");
            //数字之间两两交换,循环遍历
            for (int i = 0; i < Number.Length - 1; i++)
            {
                for (int j = 0; j < Number.Length - i - 1; j++)
                {
                    if (Number[j] > Number[j + 1])
                    {
                        int temp = Number[j + 1];
                        Number[j + 1] = Number[j];
                        Number[j] = temp;
                    }

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
    
