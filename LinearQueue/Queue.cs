using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearQueue
{
    //Boiler Plate Linear Queue
    class Queue
    {
        //Variable Declations
        #region
        private int[] element;
        private int front;
        private int back;
        private int max;
        #endregion

        //Constructor
        #region
        public Queue(int size)
        {
            element = new int[size];
            front = 0;
            back = -1;
            max = size;
        }
        #endregion

        //Methods
        #region
        //Method to Add Items to the Queue
        public void enqueue(int item)
        {
            //If Queue is Full Prints "Queue Overflow"
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

        //Method to Remove Items from the Queue
        public int dequeue()
        {
            //Checks if the Queue is Emplty
            if(front == back + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }

            //If Queue is not Empty Removed Items From Queue
            else
            {
                Console.WriteLine(element[front] + " Dequeued from Queue");
                int p = element[front++];
                Console.WriteLine();
                Console.WriteLine("Front Item is {0}", element[front]);
                Console.WriteLine("Back Item is {0} ", element[back]);
                return p;
            }
        }

        //Method to Print Items in Queue
        public void printQueue()
        {
            //Checks if Queue is Empty
            if(front == back + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            //Prints All Items in Queue
            else
            {
                for(int i = front; i <= back; i++)
                {
                    Console.WriteLine(element[i] + " Enqueued to Queue");
                }
            }
        }
        #endregion
    }
}
