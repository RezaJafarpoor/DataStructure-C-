
using DataStructure;
using DataStructure.Sorting;




 

 var ordered = MergeSort.Sort(Data.StaticData);
 foreach (var VARIABLE in ordered)
 {
     Console.Write(VARIABLE + " ");
 }
Console.WriteLine();
Console.WriteLine("number of Divides: "+ MergeSort.Divides);




