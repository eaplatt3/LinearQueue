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
            Queue Que = new Queue(10);

            Random ran = new Random();

            

            for(int i = 0; i <= 9; i++)
            {
                int num = ran.Next(50);
                Que.enqueue(num);
            }

            Que.printQueue();
            Que.dequeue();
        }
    }
}
