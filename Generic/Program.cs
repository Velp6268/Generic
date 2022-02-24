using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic;

int[] myArray = new int[5];
int[] tempMyArray = new int[5];

       for (int i = 0; i < myArray.Length; i++)
       {
         myArray[i] = i;
       }

    tempMyArray = MyArrayUtills<int>.Reverse(myArray);

    Console.WriteLine("Исходный массив");
    MyArrayUtills<int>.Print(myArray);

    Console.WriteLine("Обратный массив");
    MyArrayUtills<int>.Print(tempMyArray);