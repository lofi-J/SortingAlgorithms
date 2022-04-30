using System;

public class InsertionSort
{
    public void InsertionSortFunc(int[] array)
    {        
        int i, j, temp;
        int len = array.GetLength(0);

        for(i = 0; i < len-1; i++)
        {
            j = i;
            while(array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                if (j != 0)
                    j--;
            }
        }
    }
}
