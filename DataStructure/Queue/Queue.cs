using System.Text;

namespace DataStructure.Queue;

public class Queue
{
    private int Front, Rear;
    private bool IsFull = false;
    
    private  int[] QueueArray = new int [10];

    public void Add(int value)
    {
        if (IsFull && Rear == Front)
        {
            Reset();
        }
        if (Rear == QueueArray.Length)
        {
            Console.WriteLine("Queue is full");
            IsFull = true;
        }
        else
        {
            QueueArray[Rear] = value;
            Rear++;

        }
    }

    public void Delete()
    {
        QueueArray[Front] = default;
        Forward();
        
    }

    private void Forward()
    {
        for (int i = 1; i < 10; i++)
        {
            (QueueArray[i], QueueArray[i-1]) = (QueueArray[i-1], QueueArray[i]);
        }

        Rear--;
    }

    private void Reset()
    {
        var newQueueArray = new int [10];
        QueueArray = newQueueArray;
        Front = 0;
        Rear = 0;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Queue Elements: ");
        foreach (var VARIABLE in QueueArray)
        {
             builder.Append(VARIABLE + " ");
        }

        builder.AppendLine();
        builder.Append("Front: " + QueueArray[Front]);
        builder.AppendLine();
        var conditionString = Rear == 0 ? "Rear: "+ QueueArray[Rear]: "Rear: "+ QueueArray[Rear-1];
        builder.Append(conditionString);

        var result = builder.ToString();
        return result;

    }
}