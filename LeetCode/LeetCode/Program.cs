using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[] { 1, 5, 2, 7, 4, 8, 3 };

            //var res = TwoNumbersAdd.Violent(arr,16);
            var res = TwoNumbersAdd.HashCal(arr, 7);
            Console.WriteLine($"计算结果是：{res[0]} & {res[1]}");
            Console.ReadLine();
        }
    }
}
