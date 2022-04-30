using System;

public class QuickSort
{
    public void QuickSortFunc(int[] arr, int start, int end)
    {
        int pivot = partition(arr, start, end);
        if (start < pivot-1)
            QuickSortFunc(arr, start, pivot - 1);
        if (pivot < end)
            QuickSortFunc(arr, pivot, end);
    }

    private int partition(int[] arr, int start, int end)
    {
        int pivot = arr[(start + end) / 2];
        while(start <= end)
        {
            while (arr[start] < pivot) start++;
            while (arr[end] > pivot) end--;
            if(start <= end)
            {
                swap(arr, start, end);
                start++;
                end--;
            }
        }
        return start;
    }
        
    void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}