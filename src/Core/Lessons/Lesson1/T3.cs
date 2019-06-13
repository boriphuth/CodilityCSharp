using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1
{
    public class T3
    {
        public static void Main ()
        {
            var input = Console.ReadLine ();
            var result = Solution (input);

            Console.WriteLine (string.Join (" ", result));
        }

        public static string Solution (string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            S = S.Replace (" ", string.Empty);
            S = S.Replace ("-", string.Empty);

            if(S.Length == 2) return S;
            
            var result = "";
            var condition = (S.Length % 3);

            for (var i = 0; i < S.Length; i = i + 3)
            {
                if(i + 3 == S.Length)
                {
                    result += S.Substring (i, 3);
                }
                else if(i + 3 + 1 == S.Length)
                {
                    result += S.Substring (i, 2) + "-" + S.Substring (i+2 , 2); //"Expected": "022-198-53-24"
                    break;
                }
                else if(i + 3 + 2 == S.Length)
                {
                    result += S.Substring (i, 3) + "-" + S.Substring (i+3, 2); //"Expected": "004-448-555-583-61"
                    break;
                }
                else
                {
                    result += S.Substring (i, 3) + "-";
                }  
            }
            return result;
        }

        // public static IEnumerable<string> Split(string str, int chunkSize)
        // {
        //     return Enumerable.Range(0, str.Length / chunkSize)
        //         .Select(i => str.Substring(i * chunkSize, chunkSize));
        // }

        // public static string SubstringThreee(string S)
        // {
        //     var result = "";
        //     string cc = null, ph = null, ex = null;
        //     for (int i = 0; i < S.Length; i++)
        //     {
        //         if (i < 3)
        //         {
        //             cc = cc + S[i];
        //         }
        //         else if (i > 2 && i < 6)
        //         {
        //             ph = ph + S[i];
        //         }
        //         else
        //         {
        //             ex = ex + S[i];
        //         }
        //     }
        //     result = string.Format(cc + "-" + ph + "-" + ex);
        //     return result;
        // }
    }
}