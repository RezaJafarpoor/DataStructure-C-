using DataStructure.Queue;

var Queue = new Queue();

for (int i = 20; i < 30; i++)
{
    Queue.Add(i);
}

for (int i = 0; i <10; i++) 
    Queue.Delete();
Queue.Add(2);
Queue.Add(3);
Queue.Add(2);
Queue.Add(3);Queue.Add(2);
Queue.Add(5);
Queue.Delete();

Console.WriteLine(Queue);




