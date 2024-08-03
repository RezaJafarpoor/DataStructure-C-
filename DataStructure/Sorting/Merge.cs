using System.Collections.Immutable;
using System.Runtime.InteropServices.JavaScript;

namespace DataStructure.Sorting;

public static class Merge
{
    public static IEnumerable<int> Merging(int[] listA, int [] listB)
    {
        var index = 0;
        var headA = 0;
        var headB = 0;
        var listC = new int[listA.Length + listB.Length];
        Console.WriteLine("Size of Array C"+listC.Length);
        while (headA <= listA.Length - 1 && headB <= listB.Length -1) 
        {

            Console.WriteLine("Index :" +index);
            Console.WriteLine("Head A: "+headA);
            Console.WriteLine("Head B: "+headB);

            if (listA.ElementAt(headA) <= listB.ElementAt(headB))
            {
                listC[index] = listA[headA];
                headA++;
                index++;
            }
            else if(listB.ElementAt(headB) <= listA.ElementAt(headA))
            {
                listC[index] = listB[headB];
                headB++;
                index++;
            }
      
        }

        while (headA <= listA.Length -1)
        {
            Console.WriteLine("Index :" +index);
            Console.WriteLine("Head A: "+headA);
            Console.WriteLine("Head B: "+headB);
            listC[index] = listA[headA];
            headA++;
            index++;
        }
        while (headB <= listB.Length -1)
        {
            Console.WriteLine("Index :" +index);
            Console.WriteLine("Head A: "+headA);
            Console.WriteLine("Head B: "+headB);
            listC[index] = listB[headB];
            headB++;
            index++;
        }

        return listC;
    }
    
}