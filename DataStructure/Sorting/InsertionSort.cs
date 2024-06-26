namespace DataStructure.Sorting;

public static class InsertionSort
{
    public static void Sort(int[] array)
    {
        int count = 0;
        int comparison = 0;
        int[] temp = new int[array.Length];
        temp[0] = array[0];
        var length = array.Length;
        for (var i = 1; i < length; i++)
        {
            int j;
            for ( j = i - 1; j >= 0 && array[i] < temp[j]; j--)
            {
                comparison++;
                temp[j + 1] = temp[j];
                count++;
            }

            temp[j + 1] = array[i];
            count++;
            comparison++;

        }

        for (int index = 0; index < temp.Length; index++)
        {
            array[index] = temp[index];
        }
        
        Console.WriteLine($"Sort Completed. With {count} Swaps Total Comparisons: {comparison}");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}