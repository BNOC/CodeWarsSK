using System.Linq;

namespace CodeWars
{
    public static class FindOddInt
    {
        // URL: https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp

        public static int Find(int[] seq)
        {
            var count = seq.GroupBy(x => x).Where(e => e.Count() %2 != 0).Select(e => e.First()).SingleOrDefault();

            return count;
        }

        public static int FindBestAnswer(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
    }
}
