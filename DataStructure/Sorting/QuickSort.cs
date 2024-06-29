namespace DataStructure.Sorting;


public static class QuickSort
{
    public static int Count;
    public static int Comparison;
    public static int[] sortedArray;
    
    public static void Sort(int[] array,int low, int high)
    {
        sortedArray = array;
        Comparison++;
        if (low < high)
        {
            var pivot = low;
            var start = low;
            var end = high;
            Comparison++;
            while (start <= end)
            {
                Comparison++;
                while (start <= end && array[start] <= array[pivot])
                {
                    start++;
                }

                Comparison++;
                while (start <= end && array[end] > array[pivot])
                {
                    end--;
                }

                Comparison++;
                if (start <= end)
                {
                    (array[start], array[end]) = (array[end], array[start]);
                    Count++;

                }
            }

            (array[end], array[pivot]) = (array[pivot], array[end]);
            Count++;
            
            Sort(array,low, end-1);
            Sort(array,end+1, high);

        }
        
    }

    public static void stats()
    {
        Console.WriteLine($"Sort Completed. With {Count} swaps Total Comparisons : {Comparison}");

        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }

        

    }
}