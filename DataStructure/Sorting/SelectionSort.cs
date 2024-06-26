namespace DataStructure.Sorting;

public static class SelectionSort
{
    public static void Sort(int[] array)
    {
        int count = 0;
        var length = array.Length;
        var min = new int();
        for (var i = 0; i < length-1; i++)
        {
            min = i;
            for (var j = i+1; j < length; j++)
            {
                if (array[min] > array[j])
                {
                    (array[min], array[j]) = (array[j], array[min]);
                    count++;
                }
            }
        }
        Console.WriteLine($"Sort Completed. Swap Counter :{count}");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
    }
}