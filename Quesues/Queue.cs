using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesues
{
   public  class Queue
    {
        public int MazSize  { get; set; } // sets the number of elements beacuse this is an array

        public int[] queueArray { get; set; } // Actual array to store data

        public int Front { get; set; }  // Index to keep track of front

        public int Rear { get; set; } // Index to keep track of adds
        public int NItems { get; set; } // this wil keep track of length


        public Queue(int size)
        {
            this.MazSize = size;
            this.queueArray = new int[size];
            Front = 0;
            Rear = -1; // we make this  -1 because there is no item in the array to be considerd the last item
        }

        public void Enqueue(int item) // inserting to queue
        {
            // increment our pointer 
            Rear++;
            // insert to there the rear was incremented
            queueArray[Rear] = item;
            // increment length
            NItems++;
        }

        public int Dequeue()
        {
            int temp = queueArray[Front];
            Front++;
            if(Front == MazSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }
        public int Peek()
        {
            return queueArray[Front];
        }
    }
}
