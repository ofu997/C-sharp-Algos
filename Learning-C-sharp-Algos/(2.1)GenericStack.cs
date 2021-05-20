﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_C_sharp_Algos
{
    public static class ExecuteGenericStack
    {
        public static void Execute()
        {
            Stack<string> names = new Stack<string>();
            names.Push("Andrew");
            names.Push("Bobby");
            names.Push("Candy");
            names.Push("Dana");
            names.Push("Edith");

            Console.WriteLine("Default content of stack");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nPopping '{0}'", names.Pop());
            Console.WriteLine("Peek at next item to display what will" +
                                " be destacked: {0}", names.Peek());
            Console.WriteLine("Now, after peek, popping '{0}'", names.Pop());


            Stack<string> stack2 = new Stack<string>(names.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string name in stack2)
            {
                Console.WriteLine(name);
            }

            string[] array2 = new string[names.Count * 2];
            names.CopyTo(array2, names.Count);

            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nContents of the second copy, with " +
                                "duplicates and nulls:");
            foreach (string name in stack3)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nstack2.Contains(\"Dana\") = {0}",
                stack2.Contains("Dana"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        }
    }

    public static class GenericStack
    {
        private static void Count(int a)
        {
            Console.WriteLine("a = " + a + " on the stack");
            if (a < 3)
            {
                Count(a + 1);
            }
            Console.WriteLine("a = " + a + " off the stack");
        }
    }
}
