using System.Security.Cryptography.X509Certificates;

namespace DataStructure.Stack;

public class Stack
{
    public int[] stackArray = new int[10];
    private int index = -1;

    public void Push(int value)
    {
        if (index <=9)
        {
            index++;
            stackArray[index] = value;
        }
        else
        {
            Console.WriteLine("Stack is full");
        }
        
    }


    public void Pop()
    {
        if (index == -1)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine(stackArray[index]);
            stackArray[index] = default;
            index--;
        }
    }

    public void Peek()
    {
        Console.WriteLine(stackArray[index]);
    }
    
}