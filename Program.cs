using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {

       static void Cube(int[] cube)
        {
            int counter = 0;
            int length = cube.Length;
            while (counter < length)
            {
                cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
                counter++;
            }
        }

        static void PrintArry(int[] coll)
        {
            int count = coll.Length;
            int index = 0;
            while (index < count)
            {
                Console.Write(coll[index] + " ");
                index++;
            }
        }
        static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

            Console.Write("Введите число: ");
            int cube = Convert.ToInt32(Console.ReadLine());

           

            int[] arry = new int[cube + 1];
            Cube(arry);
            PrintArry(arry);
        }
    }
}
