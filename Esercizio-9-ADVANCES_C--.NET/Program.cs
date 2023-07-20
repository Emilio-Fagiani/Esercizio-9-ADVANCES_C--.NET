using Esercizio_9_ADVANCES_C__.NET;

var myIntQueue = new MyQueue<int>();

myIntQueue.Enqueue(10);
myIntQueue.Enqueue(20);
myIntQueue.Enqueue(30);

Console.WriteLine(myIntQueue.Dequeue());
Console.WriteLine(myIntQueue.Peek());

Console.WriteLine("----------------------------");

var myStringQueue = new MyQueue<string>();

myStringQueue.Enqueue("aaa");
myStringQueue.Enqueue("bbb");
myStringQueue.Enqueue("ccc");
myStringQueue.Enqueue("ddd");

Console.WriteLine(myStringQueue.Dequeue());
Console.WriteLine(myStringQueue.Peek());