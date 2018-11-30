using System;

namespace Lesson1.Iterations
{
   public class T3
    {
        public static void Main() {
            var input = Console.ReadLine();
            var result = Solution(input);

        Console.WriteLine(string.Join(" ", result));
        }

        public static string Solution(string s)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            s = s.Replace(" ", string.Empty);
            s = s.Replace("-", string.Empty);
            var result = "";
            if (s.Length == 9)
            {
                result += s.Substring(0, 3) + "-" + s.Substring(3, 3) + "-" + s.Substring(6, 3);
                return result;
            }
            if (s.Length == 10)
            {
                result += s.Substring(0, 3) + "-" + s.Substring(3, 3) + "-" + s.Substring(6, 2) + '-' + s.Substring(8, 2);
                return result;
            }

            for (var i = 0; i < s.Length; i = i + 3)
            {
                if ((s.Length - i) < 3 && s.Length != 10)
                {
                    result += s.Substring(i);
                }
                else if (i % 3 == 0 && s.Length != 10)
                {
                    result += s.Substring(i, 3) + "-";
                }
                else if ((s.Length - i) >= 4)
                {
                    result += s.Substring(i, 2) + '-' + s.Substring(i + 2, 2); 
                }
            }
            return result;
        }

    }
}
