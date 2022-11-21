using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace data_structures___Homework
{
    internal class Data_structures___Homework
    {
       

        internal void Go( )
        {
            //ex2 ////// 
            //12  56  -12
            //34  -98 65
            //765 543 321
            //Print the two elements in the center of the matrix using position indexes (56, -98).
            // int[,] matrix = new int[3,3];

            //matrix[0, 0] = 12;
            //matrix[0, 1] = 56;
            //matrix[0, 2] = -12;
            //matrix[1, 0] = 34;
            //matrix[1, 1] = -98;
            //matrix[1, 2] = 65;
            //matrix[2, 0] = 765;
            //matrix[2, 1] = 543;
            //matrix[2, 2] = 321;

            //Console.WriteLine(matrix[0, 1]);
            //Console.WriteLine(matrix[1, 1]);


            //----------ex3---------------
            //Create a list of names.
            //Check if that list has "Ana" (or any other name read from the user) as an element,
            //if not add it to the list and print it.

            // List<string> l1 = new List<string> {};
            // l1.Add("Ana");
            // l1.Add("Maria");
            //l1.Add("Liviu");
            //Console.WriteLine(l1.ElementAt(0));

            //===================ex4============
            // Create a stack that has two integer elements which are read from the user one by one.
            //Check the two given integers, and print "true" if one of them is 30 or if their sum is 30.Otherwise print "false".

            //Stack<int> s1 = new Stack<int>();
            //s1.Push(14);
            // s1.Push(16);

            //Console.WriteLine("Contains Element 30:{0}",s1.Contains(30));

            //==============Ex5===============
            //Using a queue which has 5 elements (read from the user and added to the queue one by one)
            //check if the top of the queue is a positive number and a multiple of 3 or a multiple of 7.
            //If not remove the top of the queue and print the new top of the queue

           
            Queue<int> q1 = new Queue<int>();

            q1.Enqueue(-7);
            q1.Enqueue(55);
            q1.Enqueue(34);
            q1.Enqueue(65);
            q1.Enqueue(22);

            int number1=q1.Count;

            if (number1  <=0) 
            {
                Console.WriteLine("positive");
            }

            else
            {
                Console.WriteLine("Negative");
            }

            int elem = q1.Dequeue();
            Console.WriteLine("elem: " + elem);
            Console.WriteLine(q1.ElementAt(0));
            Console.WriteLine("peek: " + q1.Peek());
            Console.WriteLine(q1.ElementAt(0)); 






        }
    }

}
