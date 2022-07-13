namespace CodeWarsKata.Moving_Zeros_To_The_End
{
    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var sortedArray = new OptimizedArray(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) { continue; }

                sortedArray.InsertNumber(arr[i]);
            }

            return sortedArray.Array;
        }

        public struct OptimizedArray
        {
            private int m_currentIndex;

            public int[] Array { get; set; }

            public OptimizedArray(int arrayLenght)
            {
                Array = new int[arrayLenght];
                m_currentIndex = 0;
            }

            public void InsertNumber(int number)
            {
                Array[m_currentIndex] = number;
                m_currentIndex++;
            }
        }
    }
}