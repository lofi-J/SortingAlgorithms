using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //BubbleSort bubbleSort = new BubbleSort();
        //InsertionSort insertionSort = new InsertionSort();
        //SelectionSort selectionSort = new SelectionSort();
        //MergeSort mergeSort = new MergeSort();
        //QuickSort quickSort = new QuickSort();

        //int[] array_Bubble = { 9, 7, 8, 5, 6, 4, 3, 1, 2 };
        //int[] array_Insertion = { 100, 100, 300, 200, 400, 600, 500, 0, 1, 3, 2 };
        //int[] array_Selection = { 3, 1, 2, 5, 9, 10, 8, 6, 7, 4, 0 };
        int[] array_Merge = { 5,3,4,2,1,0 };
        //int[] array_Quick = { 92340, 1789, 498721, 1892, 12389 };

        //bubbleSort.BubbleSortFunc(array_Bubble);
        //PrintArray(array_Bubble, "bubble sort");
        //insertionSort.InsertionSortFunc(array_Insertion);
        //PrintArray(array_Insertion, "insertion sort");
        //selectionSort.SelectionSortFunc(array_Selection);
        //PrintArray(array_Selection, "selection sort");
        //mergeSort.MergeSortFunc(array_Merge, 0, array_Merge.Length - 1);
        //PrintArray(array_Merge, "merge sort");
        //quickSort.QuickSortFunc(array_Quick, 0, array_Quick.Length-1);
        //PrintArray(array_Quick, "quick sort");

        PrintArray(array_Merge, "before sort");
        EmptyClass c = new EmptyClass();
        c.MergeSort(array_Merge, 0, array_Merge.Length-1);
        PrintArray(array_Merge, "Merge Sort");
    }
    public static void PrintArray(int[] array, string sortName)
    {
        int len = array.Length;
        Console.WriteLine(sortName);
        for (int i = 0; i<len; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write("\b\b ");
        Console.WriteLine("\n");
    }
}

