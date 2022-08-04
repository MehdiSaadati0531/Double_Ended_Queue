using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Ended_Queue
{
    public class Double_Ended_Queue_Array
    {
        int[] array;
        int rear = -1;
        int front = -1;
        public Double_Ended_Queue_Array(int len)
        {
            array = new int[len];
            rear = array.Length;
        }

        private bool IsEmpty()
        {
            if (front == -1 && rear == array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsFull()
        {
            if ((rear + 1 == front) || rear == 0 || (front + 1 == rear))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeQueueFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty !!!");
            }
            else if (front == -1)
            {
                Console.WriteLine("The front has reached the end of the line");
            }
            else
            {
                Console.WriteLine(array[front]);
                front--;
            }
        }

        public void EnQueueRear(int NewNumber)
        {
            if (IsFull())
            {
                Console.WriteLine("Full !!!");
            }
            else
            {
                rear--;
                array[rear] = NewNumber;
            }
        }

        public void DeQueueRear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty !!!");
            }
            else if (rear == array.Length)
            {
                Console.WriteLine("The rear has reached the end of the line");
            }
            else
            {
                Console.WriteLine(array[rear]);
                rear++;
            }
        }

        public void EnQueueFront(int NewNumber)
        {
            if (IsFull())
            {
                Console.WriteLine("FULL !!!");
            }
            else
            {
                front++;
                array[front] = NewNumber;
            }
        }

        public void PrintNumber() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty !!!");
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

    }
}
