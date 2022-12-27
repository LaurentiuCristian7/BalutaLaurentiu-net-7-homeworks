using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homeworkloops
{
    internal class loops
    {
        public void Go()
        {

            

            int[] arr = new int[] { 9, 8, 41, 10, 130 };
            int n = 5, i, j, x;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                x = arr[i];
                for (j = i - 1; j >= 0;)
                {
                    if (x < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = x;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }



           



















        }




        
    }
}


























    // -----------ex4---------

    //int[] array = { 1, 4, 5, 2, 1, 4, 3, 1, 2};


    //for (int i = 0; i < array.Length; i++)
    // {
    //     int count = 1;
    //     for (int j = i + 1; j < array.Length; j++)
    //     {
    //         if (array[i] == array[j])
    //        {
    //             count = count + 1;
    //         }
    //     }

    //    Console.WriteLine(array[i] + " repeats " + count + " times");














