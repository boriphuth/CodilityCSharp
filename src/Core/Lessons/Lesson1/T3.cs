using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Iterations
{
   public class T3
    {
        public static void Main() {
            var input = Console.ReadLine();
            List<int> A = new List<int>{1,2,3,4,5};
            int result = Solution(A, input[1], input[2]);

        //public static List A = input().ToList();

        //public static System.Int32 K = Convert.ToInt32(input());

        //public static System.Int32 L = Convert.ToInt32(input());

        //public static System.Int32 max = solution(A, K, L);

        Console.WriteLine(string.Join(" ", result));
        }

        public static int Solution(List<int> A, int K, int L) {
            object sum;
            object LEN_nd;
            object LEN_st;
            if (K + L > A.Count) {
                return -1;
            }
            else {
                if (K > L) {
                    LEN_st = K;
                    LEN_nd = L;
                }
                else {
                    LEN_st = L;
                    LEN_nd = K;
                }

                //############ST###################
                var max_st = 0;
                var index_start = 0;
                var index_stop = 0;
                var stop = A.Count - (int) LEN_st + 1;
                foreach (var i in Range(0, stop)) {
                    sum = 0;
                    foreach (var j in range(i, i + LEN_st)) {
                        sum = sum + Convert.ToInt32(A[j]);
                    }

                    if (sum > max_st) {
                        max_st = sum;
                        index_start = i;
                        index_stop = i + LEN_st - 1;
                    }
                }

                A.Remove(index_start::(index_stop + 1));
                //################ND################
                var max_nd = 0;
                index_start = 0;
                index_stop = 0;
                stop = A.Count - LEN_nd + 1;
                foreach (var i in range(0, stop)) {
                    sum = 0;
                    foreach (var j in range(i, i + LEN_nd)) {
                        sum = sum + Convert.ToInt32(A[j]);
                    }

                    if (sum > max_nd) {
                        max_nd = sum;
                        index_start = i;
                        index_stop = i + LEN_nd - 1;
                    }
                }

                var MAX = max_st + max_nd;
                return MAX;
            }

            return 0;
        }

    }
}
