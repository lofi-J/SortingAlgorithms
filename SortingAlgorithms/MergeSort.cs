using System;

public class MergeSort
{
    public int[] temp;
    void Merge(int[] arr, int start, int mid, int end)
    {
        int i = start;
        int j = mid + 1;
        int k = start;

        while (i <= mid && j <= end)
        {
            if (arr[i] < arr[j])
            {
                temp[k] = arr[i];
                i++;
            }
            else
            {
                temp[k] = arr[j];
                j++;
            }
            k++;
        }
        if (i > mid)
        {
            for (int t=j; t<=end; t++)
            {
                temp[k] = arr[t];
                k++;
            }
        }
        else
        {
            for (int t=i; t <= mid; t++)
            {
                temp[k] = arr[t];
                k++;
            }
        }

        for (int t=start; t<=end; t++)
        {
            arr[t] = temp[t];
        }

       
    }
    public void MergeSortFunc(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2;
            MergeSortFunc(arr, start, mid);
            MergeSortFunc(arr, mid + 1, end);

            Merge(arr, start, mid, end);
        }
    }
}