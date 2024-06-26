namespace DataStructure.Searches;

public static class BinarySearch
{
   private static int _count = 0;
   private static bool _found = false;
   private static int _low = 0; 
   private static int _high = 0;


    public static void Search(int[] array, int key)
    {
        
        while (_low <= _high)
        {
            _count++;
            var mid = (_low + _high) / 2;
            if (key == array[mid])
            {
                Console.WriteLine($"Element {key} found in index {mid}. Search Count: {_count}");
                _found = true;
                break;
            }
            else if (key > array[mid])
            {
                _low = mid + 1;
            }
            else
            {
                _high = mid - 1;
            }


        }

        if (_found ==false)
        {
            Console.WriteLine("Not Found");

        }
    }

    public static void RecursiveSearch(int[] array, int key)
    {
        _high = array.Length;
        
        if (_low <= _high)
        {
            _count++;
            var mid = (_low + _high) / 2;
            
            if (array[mid] == key)
            {
                Console.WriteLine($"Element {key} found. Search Count: {_count}");
                _found = true;

            }
            else if (key > array[mid])
            {
                if ((mid + 1) >= _high)
                {
                    Console.WriteLine("Not Found");

                }
                else
                {
                    RecursiveSearch(array[(mid+1).._high],key);

                }
            }
            else if (key < array[mid])
            {
                if ((mid -1) <= 0)
                {
                    Console.WriteLine("Not Found");

                }
                else
                {
                    RecursiveSearch(array[_low..(mid-1)],key);

                }
            }
            




        }
    }
}