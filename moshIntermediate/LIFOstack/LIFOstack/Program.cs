using System;
using System.Collections;
using System.Collections.Generic;

namespace LIFOstack
{
    public class Stack
    {
        List<int> myList = new List<int>();

        public void Push(object obj)
        {
            int i = (int)obj;

            myList.Add(i);
        }

        public int Pop()
        {
            var removed = myList[myList.Count - 1];
            myList.RemoveAt(myList.Count - 1);

            return removed;
        }

        //public void clear()
        //{

        //}
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

            //foreach (int item in myList)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
