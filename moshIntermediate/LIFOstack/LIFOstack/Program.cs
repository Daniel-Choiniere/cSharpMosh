using System;
using System.Collections;
using System.Collections.Generic;

namespace LIFOstack
{
    public class Stack
    {
        List<int> myList = new List<int>();

        public List<int> Push(object obj)
        {
            int i = (int)obj;

            myList.Add(i);

            return myList;
            //foreach (int item in myarray)
            //{
            //    Console.WriteLine(item);
            //}
        }

        //public object obj Pop()
        //{
        //    myarray.Remove(myarray.Count);
        //    return;
        //}

        //public void clear()
        //{

        //}
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(3);
            stack.Push(7);
            var myList = stack.Push(9);

            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
