using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_C_sharp_Algos
{
    static class ExecuteQueue
    {
        public static void Execute()
        {
            Queue myQueue = new Queue(5);
            myQueue.insert(1);
            myQueue.insert(2);
            myQueue.insert(3);
            myQueue.view(); 
        }
    }

    class Queue
    {
        private int maxSize;
        private long[] myQueue;
        private int frontIndex;
        private int rearIndex;
        private int items; 
        public Queue(int size)
        {
            maxSize = size;
            myQueue = new long[size];
            frontIndex = 0;
            rearIndex = -1;
            items = 0; 
        }

        public void insert (long j)
        {
            if (isFull())
            {
                Console.WriteLine("is full"); 
            }
            else
            {
                if (rearIndex == maxSize - 1)
                {
                    rearIndex = -1;
                }
                rearIndex++;
                myQueue[rearIndex] = j;
                items++;
            }
        }

        public long remove()
        {
            long temp = myQueue[frontIndex];
            frontIndex++; 
            if (frontIndex == maxSize)
            {
                frontIndex = 0; 
            }
            return temp; 
        }

        public bool isFull()
        {
            return (items == maxSize); 
        }

        public long peekFront()
        {
            return myQueue[frontIndex]; 
        }

        public bool isEmpty()
        {
            return (items == 0); 
        }

        public void view()
        {
            Console.WriteLine("{");
            for (int i =0; i < myQueue.Length; i++)
            {
                Console.WriteLine(myQueue[i] + " "); 
            }
            Console.WriteLine("}");
        }
    }

}
