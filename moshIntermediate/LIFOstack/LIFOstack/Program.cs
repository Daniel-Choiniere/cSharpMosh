using System;
using System.Collections;
using System.Collections.Generic;

namespace LIFOstack
{
    public class Stack
    {
        List<object> myList = new List<object>();

        public void Push(object obj)
        {
            int i = (int)obj;

            myList.Add(i);
        }

        public object Pop()
        {
            var removed = myList[myList.Count - 1];
            myList.RemoveAt(myList.Count - 1);

            return removed;
        }

        public void clear()
        {
            myList.Clear();

            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());   
        }
    }
}
