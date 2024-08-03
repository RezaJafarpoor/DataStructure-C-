namespace DataStructure.Sorting;


public static class QuickSort
{
    private static int _count;
    private static int _comparison;
    private static int[] _sortedArray;
    
    public static void Sort(int[] array,int low, int high)
    {
        _sortedArray = array;
        _comparison++;
        if (low < high)
        {
            var pivot = low;
            var start = low;
            var end = high;
            _comparison++;
            while (start <= end)
            {
                _comparison++;
                while (start <= end && array[start] <= array[pivot])
                {
                    start++;
                }

                _comparison++;
                while (start <= end && array[end] > array[pivot])
                {
                    end--;
                }

                _comparison++;
                if (start <= end)
                {
                    (array[start], array[end]) = (array[end], array[start]);
                    _count++;

                }
            }

            (array[end], array[pivot]) = (array[pivot], array[end]);
            _count++;
            
            Sort(array,low, end-1);
            Sort(array,end+1, high);

        }
        
    }

    public static void Stats()
    {
        Console.WriteLine($"Sort Completed. With {_count} swaps Total Comparisons : {_comparison}");

        for (int i = 0; i < _sortedArray.Length; i++)
        {
            Console.Write(_sortedArray[i] + " ");
        }

        

    }
}