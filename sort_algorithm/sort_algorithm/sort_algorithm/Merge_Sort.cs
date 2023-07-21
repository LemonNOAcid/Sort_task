using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace sort_algorithm
{
    public  class Merge_Sort
    {
        public void Merge_run(int[] Number)
        {
            Console.WriteLine("我是归并");
            int Low = 0;
            int Height = Number.Length-1;
            Merge(Number, Low, Height);
            for (int i = 0; i < Number.Length; i++)
            {
                Console.Write(Number[i] + ",");
            }
            Console.WriteLine();
        }
        private void Merge(int[] Number ,int Low,int Height) 
        {
            if(Low<Height) 
            {
                //分治法
                int Mid=(Low+Height)/2;
                //左边分治
                Merge(Number, Low,Mid );
                //右边分治
                Merge(Number, Mid+1, Height );
                Merge_sort(Number,Low, Mid, Height);
            }
        }
        private void Merge_sort(int[] Number, int Low,int Mid, int Height) 
        {
            int Left,Right,index;
            int[] Temp_Arr = new int[Number.Length];
            for (index = Low; index <=Height; index++)
            {
                Temp_Arr[index] = Number[index];
            }//填充
            for (index = Left = Low, Right = Mid + 1; Left <= Mid && Right <= Height && index <= Height; index++)
            {
                if (Temp_Arr[Left] <= Temp_Arr[Right])
                {
                    Number[index] = Temp_Arr[Left++];
                }
                else { Number[index] = Temp_Arr[Right++]; }
            }
            while (Left <= Mid) { Number[index++] = Temp_Arr[Left++]; }//左边合
            while (Right <= Height) { Number[index++] = Temp_Arr[Right++]; }//右边合

        }
    }
}
