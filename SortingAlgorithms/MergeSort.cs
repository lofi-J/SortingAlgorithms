using System;

public class MergeSort
{
    int[] temp = new int[10]; //임시 배열의 크기 10
    public void Merge(int[] array, int start, int middle, int end)
    {
        int left = start;
        int right = middle + 1;
        int index = start;

        while( left <= middle && right <= end )
        {
            if (array[left] <= array[right])
            {
                temp[index] = array[left];
                left++;
            }
            else
            {
                temp[index] = array[right];
                right++;
            }
            index++;
        }

        if (left > middle)
        {
            for (int i = right; i <= end; i++)
            {
                temp[index] = array[i];
                index++;
            }
        }
        else
        {
            for (int i = left; i <= middle; i++)
            {
                temp[index] = array[i];
                index++;
            }
        }
        
        for (int i = start; i <= end; i++)
        {
            array[i] = temp[i];
        }

    }
    public void MergeSortFunc(int[] array, int start, int end)
    {        
        if (start < end)
        {
            int middle = (start + end) / 2;
            MergeSortFunc(array, start, middle);
            MergeSortFunc(array, middle + 1, end);

            Merge(array, start, middle, end);
        }
    }
}
