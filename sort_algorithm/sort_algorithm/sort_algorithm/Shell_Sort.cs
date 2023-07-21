using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm
{
    public class Shell_Sort
    {
        public void Shell_sort(int[] Number)
        {
            Console.WriteLine("我是希尔");
            for(int h = Number.Length / 2; h > 0; h = h / 2)//进行分组
            {
                //找到分组位置,注意分组从切割位置分，找到前面的一个数字为分组
                for(int i=h; i < Number.Length; i++) 
                {
                    int temp = Number[i];
                    //与组内之前的元素进行比较
                    for(int k=i-h; k>=0; k=k-h) 
                    {
                        if (temp < Number[k]) 
                        {
                            Number[k+h] =Number[k];
                            Number[k] = temp;
                           
                        }
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
