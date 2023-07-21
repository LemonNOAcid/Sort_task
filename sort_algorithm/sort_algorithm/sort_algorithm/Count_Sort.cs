using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm
{
    public class Count_Sort
    {
        public void Count_sort(int[] Number) 
        {//适合波动不大的整数
            int Max = Number[0], Min = Number[0];
            for(int i = 1; i < Number.Length; i++) 
            {
                if (Number[i] > Max) Max = Number[i];
                if (Number[i] < Min) Min = Number[i];
            }
            Console.WriteLine("Min:{0},Max:{1}",Min, Max);
            int[] Count_Arr = new int[Max - Min + 1];
            //生成的是从小到大的每一个数字
            for (int i=0;i < Number.Length; i++) 
            {
                Count_Arr[Number[i] - Min]++;
                //找到对应位置的下标，进行+1计数
            }
            int index = 0;
            for(int i=0;i<Count_Arr.Length; i++) 
            {//输出存储的数值
                for (int j = 0; j < Count_Arr[i]; j++) 
                {
                    Number[index++] = i + Min;
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
