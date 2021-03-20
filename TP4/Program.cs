using System;
using System.Collections.Generic;
using static System.Console;
using Microsoft.VisualBasic;

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


            

            string values = "321*+9-";
            WriteLine($"\n\nThe characters are: {values}");
            Stack<int> stack = new Stack<int>();

            foreach (char item in values)
            {
                if (Information.IsNumeric(item))
                {
                    stack.Push(Convert.ToInt16(item.ToString()));
                }   
                else
                {
                    int num2 = stack.Pop();
                    int num1 =  stack.Pop();

                    num1 = Calculator(num1,num2,item.ToString());
                    stack.Push(num1);

                }
            }

            WriteLine($"Output: {stack.Pop()}");

        }
        static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Write($"{item} - ");   
            }
        }
        public static int Calculator(int num1, int num2, string symbol)
        { 
                if (symbol == "+")
                {
                    return num1 + num2;
                }
                else if (symbol == "-" )
                {
                    return num1 - num2;
                }
                else if (symbol == "*")
                {
                    return num1 * num2;
                }
                else 
                {
                    return num1 / num2;
                }
    
            
            
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