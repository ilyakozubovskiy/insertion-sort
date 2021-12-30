using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace InsertionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with insertion sort algorithm.
        /// </summary>
        public static void InsertionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int i = 1; i < array.Length; ++i)
            {
                int value = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > value)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }

                array[j + 1] = value;
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive insertion sort algorithm.
        /// </summary>
        public static void RecursiveInsertionSort(this int[] array)
        {
            RecursiveInsertionSort(array, 1);
        }

        public static void RecursiveInsertionSort(int[] array, int startIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0 || startIndex == array.Length)
            {
                return;
            }

            int value = array[startIndex];
            int j = startIndex - 1;

            while (j >= 0 && array[j] > value)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = value;

            RecursiveInsertionSort(array, startIndex + 1);
        }
    }
}
