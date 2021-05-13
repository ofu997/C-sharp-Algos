using System;
using System.Collections.Generic;
using System.Text;
using static System.Console; 

namespace Learning_C_sharp_Algos
{
    static class ExecuteStack
    {
        public static void Execute()
        {
            Stack theStack = new Stack(4);
            theStack.Push("Star Wars");
            theStack.Push("The Hobbit");
            theStack.Push("The Green Mile");
            theStack.Push("E.T.");
            theStack.Push("Up");

            WriteLine(theStack.Peek() + " is at the top of the stack"); 

            WriteLine("the stack contains "); 
            while(!theStack.isEmpty())
            {
                string movie = theStack.Pop();
                WriteLine(movie); 
            }
        }
    }

    class Stack
    {
        private int maxSize;
        private string[] stackArray;
        // indicates index of stackArray
        private int top; 

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1; 
        }

        public void Push(string m)
        {
            if (isFull())
            {
                WriteLine("This stack is full"); 
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public bool isFull()
        {
            return (maxSize - 1 == top); 
        }

        public string Pop()
        {
            if (isEmpty())
            {
                WriteLine("The stack is empty");
                return "--"; 
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top]; 
            }
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public string Peek()
        {
            return stackArray[top]; 
        }
    }
}
