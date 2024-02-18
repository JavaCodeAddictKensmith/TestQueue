using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var queue = new Queue(10);

            while (!exit)
            {
                Console.WriteLine("Choose an operations:");
                Console.WriteLine("1) Push");
                Console.WriteLine("2) Pop");
                Console.WriteLine("3) Display queue");
                Console.WriteLine("4) Peek Stack");
                Console.WriteLine("5) Size of Stack");

                var key = Console.ReadKey();
                char operation = key.KeyChar;

                Console.WriteLine();

                int n;

                switch (operation)
                {
                    case '1':
                        Console.Write("Insert a number: ");
                        var line = Console.ReadLine();

                        if (int.TryParse(line, out n))
                            queue.Enqueue(n);
                        else
                            Console.WriteLine("Invalid input...");
                        break;

                    case '2':
                        n = queue.DequFast();
                        Console.WriteLine($"Deleted data: {n}");
                        break;

                    case '3':
                        queue.Display();

                        break;
                    case '4':
                        queue.Dequeue();
                        //n = stack.Peek();
                        //Console.WriteLine($"Last Number is: {n}");


                        break;
                    case '5':
                        queue.Size();

                        break;


                    default:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                }

                Console.WriteLine();
            }

        }

        class Queue
        {
            public int Count { get; private set; }
            private int[] queue;

            public Queue(int size)
            {
                queue = new int[size];
                Count = 0;
            }

            public void Enqueue(int n)
            {
                if (Count == queue.Length)
                {
                    Console.WriteLine("Stack is full!");
                }
                else
                {
                    queue[Count++] = n;
                }
            }

            public bool IsEmpty()
            {
                if (Count == 0)
                {


                    Console.WriteLine("True");
                    return true;
                }
                Console.WriteLine("False");
                return false;



            }

            public int Size()
            {
                Console.WriteLine("Size of the stack is: " + Count);

                return Count;
            }

            public int Dequeue()
            {
                int result = -1;

                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    result = queue[Count - 1];
                    Console.WriteLine($" First Item to be removed is: {result}");
                }

                return result;
            }





            public int DequFast()
            {
                int result = -1;

                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    result = queue[--Count];
                    Console.WriteLine($" First Item to be removed is: {result}");
                }

                return result;
            }

            public void Display()
            {
                if (Count == 0)
                {
                    Console.WriteLine("Stack is empty!");
                }
                else
                {
                    Console.WriteLine("Stack data:");
                    for (int i = Count - 1; i >= 0; i--)
                        Console.WriteLine(queue[i]);
                }
            }
        }
    }
}
