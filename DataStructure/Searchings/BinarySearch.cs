namespace DataStructure.Searchings;

public static class BinarySearch
{
    public static void Search(int[] array, int key)
    {
        var count = 0;
        var found = false;
        var low = 0;
        var high = array.Length;
        while (low <= high)
        {
            count++;
            var mid = (low + high) / 2;
            if (key == array[mid])
            {
                Console.WriteLine($"Element {key} found in index {mid}. Search Count: {count}");
                found = true;
                break;
            }
            else if (key > array[mid])
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }


        }

        if (found ==false)
        {
            Console.WriteLine("Not Found");

        }
    }
}