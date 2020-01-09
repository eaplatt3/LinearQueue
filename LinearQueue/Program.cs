using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates Queue
            Queue Que = new Queue(10);

            //Creates Random 
            Random ran = new Random();

            for(int i = 0; i <= 9; i++)
            {
                //Assigins Random Number to num
                int num = ran.Next(50);
                Que.enqueue(num); //Populates Queue
            }

            //Prints Queue
            Que.printQueue();

            //Removes First Item
            Que.dequeue();
        }
    }
}
