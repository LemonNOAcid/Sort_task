using sort_algorithm;
using System;

namespace std
{
    public class sort_algorithm
    {

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一串数字，中间用逗号隔开");
            string Numberstr = Console.ReadLine();
            string[] Numberstr_1 = Numberstr.Split(",");
            int[] Number = new int[Numberstr_1.Length];
            for (int i = 0; i < Number.Length; i++)
            {
                Number[i] = int.Parse(Numberstr_1[i]);
            }

            //Bubble_Sort bubble = new Bubble_Sort();
            //bubble.bubble(Number);
            //Insert_Sort insert = new Insert_Sort();
            //insert.insert(Number);
            //Select_Sort select = new Select_Sort();
            //select.select(Number);
            //Quick_Sort quick_sort = new Quick_Sort();
            //quick_sort.QuickSort_run(Number, 0, Number.Length - 1);
            //Shell_Sort shellsort = new Shell_Sort();
            //shellsort.Shell_sort(Number);
            //Merge_Sort merge = new Merge_Sort();
            //merge.Merge_run(Number);
            Count_Sort count = new Count_Sort();
            count.Count_sort(Number);

            Console.WriteLine();
        }

       
        
       

        
    }
}

