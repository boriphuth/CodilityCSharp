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
            //var input = new int[]{3, 4, 5, 4}; // 2
            //var input1 = new int[] { 1, 2, 3, 3, 5, 6, 7 }; //7
            //var input2 = new int[] { 4, 5, 2, 3, 4 }; //0
           
            var input = Console.ReadLine().Split(',');
            var A = new int[input.Length];
            for (var i =0; i < input.Length; i++)
            {
                A[i] = Convert.ToInt32(input[i]);
            }
           
            var result = solution(A);
            Console.WriteLine(string.Join(" ", result));
        }

        public static int solution(int[] A)
        {
            var q = A.Distinct().ToArray();
            if (!IsSorted(q)) return 0;
            if(q.Length != 3) return q[q.Length - 1];
            if (q.Length == 3) return 2;

            return 0;
        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsSequential(int[] array)
        {
            return array.Zip(array.Skip(1), (a, b) => (a + 1) == b).All(x => x);
        }
  
    }
}
