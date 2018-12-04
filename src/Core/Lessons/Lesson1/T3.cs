using System;

namespace Lesson1
{
   public class T3
    {
        public static void Main() {
            var input = Console.ReadLine();
            var result = Solution(input);

        Console.WriteLine(string.Join(" ", result));
        }

        public static string Solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            S = S.Replace(" ", string.Empty);
            S = S.Replace("-", string.Empty);
            var result = "";

            if (S.Length == 9) {
                result += S.Substring(0, 3) + "-" + S.Substring(3, 3) + "-" + S.Substring(6, 3);
                return result;
            }

            if (S.Length == 10) {
                result += S.Substring(0, 3) + "-" + S.Substring(3, 3) + "-" + S.Substring(6, 2) + '-' +
                          S.Substring(8, 2);
                return result;
            }

            for (var i = 0; i < S.Length; i = i + 3)
            {
                if ((S.Length - i) < 3 && S.Length != 10)
                {
                    result += S.Substring(i);
                }
                else if (i % 3 == 0 && S.Length != 10)
                {
                    result += S.Substring(i, 3) + "-";
                }
                else if ((S.Length - i) >= 4)
                {
                    result += S.Substring(i, 2) + '-' + S.Substring(i + 2, 2); 
                }
            }
            return result;
        }

    }
}
