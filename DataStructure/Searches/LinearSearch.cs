namespace DataStructure.Searches;

public static class LinearSearch
{
    
    public static void Search(int[] array, int key)
    {
        var found = false;
        var count = 0;
        for (var index = 0; index < array.Length; index++)
        {
            count++;
            if (array[index] == key)
            {
                Console.WriteLine($"Element {key} is in index {index}. Search Count: {count}");
                found = true;

            }
        }

        if (found ==false)
        {
            Console.WriteLine("Not Found");

        }

    }
}