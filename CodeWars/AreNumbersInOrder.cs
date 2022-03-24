using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    // Kata https://www.codewars.com/kata/56b7f2f3f18876033f000307/train/csharp

    public class AreNumbersInOrder
    {
        public static bool IsAscOrder(int[] arr)
        {
            var i = 0;
            while (i < arr.Length)
            {
                if (i != 0)
                {
                    if (arr[i] < arr[i - 1])
                        return false; 
                }
                i++;
            }

            return true;
        }

        public static bool IsAscOrderBestAnswer(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                if (arr[i - 1] > arr[i]) return false;
            return true;
        }

        public static bool IsAscOrderBestAnswerLinq(int[] arr)
        {
            return arr.SequenceEqual(arr.OrderBy(x => x));
        }
    }
}
