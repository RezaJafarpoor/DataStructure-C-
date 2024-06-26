namespace DataStructure.Sorting;

public static class InsertionSort
{
    public static void Sort(int[] array)
    {
        int count = 0;
        int comparison = 0;
        var length = array.Length;
        for (var i = 1; i < length; i++)
        {
            int temp = array[i];
            int j = i - 1;
            comparison++;
            for ( ; j >= 0 && array[j] > temp; j--)
            {
                comparison++;
                array[j + 1] = array[j];
                count++;

            }

            array[j + 1] = temp;

        }

       
        
        Console.WriteLine($"Sort Completed. With {count} Swaps Total Comparisons: {comparison}");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}