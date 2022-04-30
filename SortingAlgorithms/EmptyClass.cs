using System;

public class EmptyClass
{
    private int[] tempArray = new int[10];
    
    public void Merge(int[] array, int start, int middle, int end)
    {
        int left = start;
        int index = start;
        int right = middle + 1;

        while( left <= middle && right <= end )
        {
            if (array[left] <= array[right])
            {
                tempArray[index] = array[left];
                left++;
            }
            else
            {
                tempArray[index] = array[right];
                right++;
            }
            index++;
        }
        if (left > middle)
        {
            for (int i = right; i<=end; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
        }
        else
        {
            for(int j = left; j <= middle; j++)
            {
                tempArray[index] = array[j];
                index++;
            }
        }

        for(int k = start; k<=end; k++)
        {
            array[k] = tempArray[k];
        }
    }

    public void MergeSort(int[] array, int start, int end)
    {
        int middle;

        if ( start < end)
        {
            middle = (start + end) / 2;
            MergeSort(array, start, middle);
            MergeSort(array, middle + 1, end);

            Merge(array, start, middle, end);
        }        
    }
}

