using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Iterations
{
   public class T4
    {
        public static void Main()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            int result = Solution(input);
            Console.WriteLine(string.Join(" ", result));
        }

        public static int Solution(int n)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //var binary = Convert.ToString(n, 2).Trim('0');
            //var gaps = binary.Split('1');
            //Array.Sort(gaps);
            //return gaps[gaps.Length - 1].Length;
            return 0;
        }
    }
}
