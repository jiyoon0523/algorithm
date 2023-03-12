using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmers
{
    public class DivisibleNumberArray
    {

        static void Main(string[] args)
        {
            foreach (var ans in Solution(new int[] { 5, 9, 7, 10 }, 5)) Console.WriteLine(ans);
            foreach (var ans in Solution(new int[] { 2, 36, 1, 3 }, 1)) Console.WriteLine(ans);
            foreach (var ans in Solution(new int[]{3, 2, 6}, 10)) Console.WriteLine(ans);
        }

        public static int[] Solution(int[] arr, int divisor)
        {
            int[] answer = new int[] { };

            var list = new List<int>();
            foreach(var ele in arr)
            {
                if (ele % divisor == 0) list.Add(ele);
            }
            list.Sort();
            answer = list.Count > 0 ? list.ToArray() : new int[] { -1 };

            return answer;
        }

        public static int[] Solution2(int[] arr, int divisor)
        {
            int[] answer = new int[] { };

            foreach (var ele in arr)
            {
                if (ele % divisor == 0) answer = answer.Append(ele).ToArray();
            }
            if (answer.Length < 1) answer = answer.Append(-1).ToArray();
            Array.Sort(answer);

            return answer;
        }
    }
}
