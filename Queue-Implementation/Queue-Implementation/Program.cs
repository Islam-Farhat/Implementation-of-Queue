#region Queue implementation using linkedlist

using System;
using System.Collections.Generic;

namespace Queue_Implementation
{
    class Program
    {
        class Queue<t>
        {
            LinkedList<t> list = new LinkedList<t>();
            public void Enqueue(t item)
            {
                list.AddLast(item);
            }
            public t Dequeue()
            {
                t item = list.First.Value;
                list.RemoveFirst();
                return item;
            }
            public t Peek()
            {
                return list.First.Value;

            }

            public int Count { get { return list.Count; } }
        }
        static void Main(string[] args)
        {
            Queue<int> queueList = new Queue<int>();
            queueList.Enqueue(100);
            queueList.Enqueue(200);
            queueList.Enqueue(300);
            queueList.Enqueue(400);

            Console.WriteLine($"Count: {queueList.Count}");
            int count = queueList.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queueList.Dequeue());
            }

        }
    }
}

#endregion


#region Queue implementation using array

using System;
using System.Collections.Generic;

namespace Queue_Implementation
{
    class Program
    {
        class Queue<t>
        {

            t[] array;
            // int front = 0;
            int rear = -1;
            public Queue()
            {
                array = new t[30];

            }
            public void Enqueue(t item)
            {
                if (rear >= 30)
                {
                    Console.WriteLine("Queue Overflow");
                    return;
                }
                array[++rear] = item;

            }
            public t Dequeue()
            {
                if (rear < 0)
                {
                    Console.WriteLine("Queue is empty!");
                    return default;
                }
                t item = array[0]; rear--;
                //shefit in my array
                for (int i = 0; i <= rear; i++)
                {
                    array[i] = array[i + 1];
                }
                return item;
            }

            public t Peek()
            {
                return array[0];
            }
            public void printQueue()
            {
                for (int i = 0; i <= rear; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

        }
        static void Main(string[] args)
        {
            Queue<int> queueList = new Queue<int>();
            queueList.Enqueue(100);
            queueList.Enqueue(200);
            queueList.Enqueue(300);
            queueList.Enqueue(400);
            queueList.printQueue();

            Console.WriteLine("\n\n\n" + queueList.Dequeue() + "\n\n\n");

            queueList.printQueue();
            Console.WriteLine();
            queueList.Enqueue(1);
            queueList.Enqueue(2);
            queueList.Enqueue(3);
            queueList.Enqueue(4);
            queueList.printQueue();
            Console.WriteLine("\n" + queueList.Peek());

        }
    }
}

#endregion


#region Queue implementation using ArrayList

using System;
using System.Collections;
namespace Queue_Implementation
{
    class Queue<t>
    {
        ArrayList list = new ArrayList();

        public void Enqueue(t item)
        {
            list.Add(item);
        }

        public t Dequeue()
        {
            t item = (t)list[0];
            list.RemoveAt(0);
            return item;
        }

        public t Peek()
        {
            t item = (t)list[0];
            return item;
        }

        public void print()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Porgram
    {
        public static void Main()
        {
            Queue<int> queueList = new Queue<int>();
            queueList.Enqueue(1);
            queueList.Enqueue(2);
            queueList.Enqueue(3);
            queueList.Enqueue(4);
            queueList.Dequeue();

            queueList.print();


        }
    }
}

#endregion