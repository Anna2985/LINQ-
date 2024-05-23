using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ學習
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 4, 5, 5, 5, 5 };

            var distinctnumber = numbers.Distinct();

            Console.WriteLine("列出非重複數字");

            foreach (var number in distinctnumber)
            {
                Console.WriteLine(number);
            }
        }
           
    }
}
