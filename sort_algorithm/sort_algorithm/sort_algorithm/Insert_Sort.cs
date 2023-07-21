using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm
{
    public class Insert_Sort
    {
        public void insert(int[] Number)
        {//发现目标数字直接插入，其他数字集体向后移动
            Console.WriteLine("l我是插入");
            for (int i = 1; i < Number.Length; i++)
            {
                int temp = Number[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (temp < Number[j])
                    //如果前面的数字比较大，一个个交换
                    {
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
