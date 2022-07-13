using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.Delete_occurrences_of_an_element_if_it_occurs_more_than_n_times
{
    public static class Kata
    {
        private static void Main()
        {
            DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> result = new();

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                int dublicatesCount = arr.GetDublicatesCount(num, i);

                if (dublicatesCount >= x) { continue; }

                result.Add(num);
            }

            return result.ToArray();
        }

        private static int GetDublicatesCount(this int[] array, int dublicate, int endIndex)
        {
            return array.Take(endIndex).Count(n => n == dublicate);
        }
    }
}