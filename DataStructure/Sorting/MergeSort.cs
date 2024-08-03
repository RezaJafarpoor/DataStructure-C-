namespace DataStructure.Sorting;

public static class MergeSort
{
    public static int Divides { get; set; } = 0;
    
    public static int [] Sort(int[] listA)
    {
        
        if (listA.Length <= 1)
        {
            return listA;
        }

        var firstHalf = new int[listA.Length/2];
        var secondHalf = new int[listA.Length/2];
        firstHalf = listA[0 .. (listA.Length / 2)];
        Divides++;
        secondHalf = listA[(listA.Length / 2) .. listA.Length];
        Divides++;
        firstHalf = Sort(firstHalf);
        secondHalf = Sort(secondHalf);
        return Merge.Merging(firstHalf, secondHalf);
    }
    
}