namespace DataStructure.Sorting;

public static class BubbleSort
{
    public static void Sort(int[] array)
    {
        int count = 0;
        var length = array.Length;
        bool swap;
        for (int i = 0; i <= length-1; i++)
        {
            swap = false;
            for (int j = 0; j <length -1; j++)
            {
                if (array[j] > array[j+1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    count++;
                    swap = true;
                }
            }

            if (swap ==false)
            {
                Console.WriteLine($"Sort Completed. Swap Counter: {count}" );
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
                Console.Write(array[i] + " ");
        }
    }
}