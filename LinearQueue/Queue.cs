using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearQueue
{
    class Queue
    {
        //Variable Declations 
        private int[] element;
        private int front;
        private int back;
        private int max;

        //Constructor
        public Queue(int size)
        {
            element = new int[size];
            front = 0;
            back = -1;
            max = size;
        }

        //Method to add items to the Queue
        public void enqueue(int item)
        {
            if(back == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }

            //Changes the Last Element and the Size
            else
            {
                element[++back] = item;
            }
        } 
    }
}
