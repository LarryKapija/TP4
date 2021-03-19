
using System;
using System.Collections.Generic;
using static System.Console;

namespace TP4
{
    class Program
    {
        static void Main()
        {

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ylen");
            queue.Enqueue("Amaury");
            queue.Enqueue("Alejandro");
            queue.Enqueue("Miguel");
            Write("Original queue:\t");
            PrintQueue(queue);

            string reverse ="";
            foreach (var element in queue)
            {
                reverse = $"{element}|{reverse}";
                //Write($"{reverse}{queue.Dequeue()}");
            }
            queue.Clear();

            string temporal = "";
            foreach (char item in reverse)
            {
                if(item.ToString() == "|")
                {
                    queue.Enqueue(temporal);
                    temporal="";
                    continue;
                }
                temporal +=item;
            }

            temporal=null;
            reverse=null;
            GC.Collect();

            Write("\nTwist queue:\t");
            PrintQueue(queue);
        }
        static void PrintQueue(Queue<string> queue)
        {
            foreach (
                var item in queue)
            {
                Write($"{item} -> ");
            }
        }
    }
}
