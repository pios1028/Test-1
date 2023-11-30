﻿using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> My_dict1 =
            new Dictionary<int, string>();
            // Adding key/value pairs
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "C#");
            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                ele1.Key, ele1.Value);
            }
            Console.WriteLine();
            // Creating another dictionary
            // using Dictionary<TKey,TValue> class
            // adding key/value pairs without
            // using Add method
            Dictionary<string, string> My_dict2 =
            new Dictionary<string, string>(){
                {"a.1", "Dog"},
                {"a.2", "Cat"},
                {"a.3", "Pig"}
            };
            foreach (KeyValuePair<string, string> ele2 in My_dict2)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }

            // Using Remove() method
            My_dict1.Remove(1123);
            My_dict1.Add(1122, "Like");

            Console.WriteLine();
            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                ele1.Key, ele1.Value);
            }

            Console.WriteLine();
            if (My_dict1.ContainsKey(1122) == true)
            {
                Console.WriteLine("Key is found...!!");
            }
            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            if (My_dict1.ContainsValue("GeeksforGeeks") == true)
            {
                Console.WriteLine("Value is found...!!");
            }
            else
            {
                Console.WriteLine("Value is not found...!!");
            }
        }
    }
}
