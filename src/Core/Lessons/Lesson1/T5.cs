using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
   public class T5
    {
        public static void Main()
        {
            var input = Console.ReadLine();
           input =  "Sun 10:00-20:00";
            int result = Solution(input);
            Console.WriteLine(string.Join(" ", result));
        }

        public static int Solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var days = new List<string> {"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};
        
            return 0;
        }
    }
}
