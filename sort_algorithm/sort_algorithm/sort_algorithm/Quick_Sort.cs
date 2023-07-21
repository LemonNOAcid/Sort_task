using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithm
{
    public class Quick_Sort
    {
        public void QuickSort_run(int[] Number, int Begin, int End)
        {
            //二分法，选择一个目标数字，左边比目标数字小，右边比目标数字大

            Console.WriteLine("我是快排");
            QuickSort(Number, Begin, End);
            for (int i = 0; i < Number.Length; i++)
            {
                Console.Write(Number[i] + ",");
            }
            Console.WriteLine();
        }
        public void QuickSort(int[] Number, int Begin, int End)
        {
            if (Begin > End) return;//结束递归
            int pivotIndex = QuickSort_one(Number, Begin, End);//确认目标位置
            QuickSort(Number, pivotIndex + 1, End);//左边子部分
            QuickSort(Number, Begin, pivotIndex - 1);//右边子部分
        }
        public int QuickSort_one(int[] Number, int Begin, int End)
        {
            int Pivot = Number[Begin];
            int i = Begin; int j = End;//开始位置和结束位置
            while (i < j)//分子部
            {
                while (Number[j] >= Pivot && i < j)
                    j--;
                Number[i] = Number[j];
                while (Number[i] <= Pivot && i < j)
                    i++;
                Number[j] = Number[i];
            }

            Number[i] = Pivot;
            return i;


        }
    }
}
