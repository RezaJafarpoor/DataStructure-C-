namespace DataStructure.Sorting;

public static class SelectionSort
{
    public static void Sort(int[] array)
    {
        int count = 0;
        int comparison = 0;
        var length = array.Length;
        int min; 
        for (var i = 0; i < length-1; i++)
        {
            comparison++;
            min = i;
            for (var j = i + 1; j < length; j++)
            {
                comparison++;

                if (array[min] > array[j])
                {
                    min = j;

                }
            }
            if (min != i)
            {
                (array[i], array[min]) = (array[min], array[i]);
                count++;
            }
        }
        Console.WriteLine($"Sort Completed. With {count} Swaps   Total Comparisons : {comparison}");


        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
    }
}