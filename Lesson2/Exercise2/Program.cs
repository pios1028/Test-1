﻿using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");
            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5
            if (strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek()); //prints H
                Console.WriteLine(strQ.Peek()); //prints H
            }
            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5
            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); //prints Hello
            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0
        }
    }
}
