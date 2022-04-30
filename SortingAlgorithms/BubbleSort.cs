using System;

public class BubbleSort
{
    public void BubbleSortFunc(int[] array)
    {
        int len = array.GetLength(0);

        for(int i=0; i<len-1; i++)
        {
            for(int j=0; j<len-i-1; j++)
            {
                if(array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

