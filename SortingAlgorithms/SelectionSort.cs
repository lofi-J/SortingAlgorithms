using System;

public class SelectionSort
{
    public void SelectionSortFunc(int[] array)
    {
        int len = array.GetLength(0);
        int i, j, min, temp;

        for (i = 0; i < len - 1; i++)
        {
            min = i;
            for (j = i + 1; j < len; j++)
            {
                if(array[min] > array[j])
                {
                    min = j;
                }
            }
            if (i != min)
            {
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
    }
}
