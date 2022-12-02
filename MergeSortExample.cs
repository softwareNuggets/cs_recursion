using System;


namespace Recursion
{
    public class MergeSortExample
    {
        public void Run()
        {


            int[] array = new int[] { 33, 27, 43, 1, 9, 79, 13 };
            PrintArray(array);

            MergeSort(array, 0, array.Length - 1);

            PrintArray(array);
        }

        private void MergeSort(int[] array, int left, int right)
        {

            if (left < right)                       // stop condition 
            {
                int mid = left + ((right - left) / 2) + 1;
                MergeSort(array, left, mid - 1);
                MergeSort(array, mid, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int maxLeftIndex = mid - left;
            int maxRightIndex = right - mid + 1;

            int[] leftSideArray = new int[maxLeftIndex];
            int[] rightSideArray = new int[maxRightIndex];

            LoadArray(array, leftSideArray, maxLeftIndex, left);
            LoadArray(array, rightSideArray, maxRightIndex, mid);

            int i = 0, j = 0, k = left;
            while (i < maxLeftIndex && j < maxRightIndex)
            {
                if (leftSideArray[i] <= rightSideArray[j])
                {
                    array[k++] = leftSideArray[i++];
                    continue;
                }

                array[k++] = rightSideArray[j++];
            }

            if (i == maxLeftIndex)
            {
                for (int index = j; index < maxRightIndex; k++, index++)
                {
                    array[k] = rightSideArray[index];
                }
            }

            if (j == maxRightIndex)
            {
                for (int index = i; index < maxLeftIndex; k++, index++)
                {
                    array[k] = leftSideArray[index];
                }
            }
        }

        private void LoadArray(int[] orig, int[] side, int maxCount, int startPos)
        {
            for (int i = 0; i < maxCount; i++)
            {
                side[i] = orig[startPos + i];
            }
        }

        private void PrintArray(int[] array)
        {
            int i = 0;
            while (i < array.Length)
            {
                Console.Write("{0} ", array[i++]);
            }
            Console.WriteLine();
        }
    }
}
