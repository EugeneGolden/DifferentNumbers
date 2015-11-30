using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DifferentNumbers
{
    class UniqueNumbers
    {
        //Дано натуральное число n. Определить количество различных цифр в нем (в числе 4564765 ответ 4).
        public int FindUniqueNumbers(int number)
        {
            int amount = 0;                         //initial amount of different numbers
            ArrayList al = new ArrayList();         //create an empty list
            string line = Convert.ToString(number); //represents the number as a string
            char[] array = line.ToCharArray();      //now represents the string as an array

            for (int i = 0; i < array.Length; i++)
            {
                if (al.Contains(array[i]))
                {
                    continue;
                }
                else
                {
                    al.Add(array[i]);
                    amount++;
                }
            }
            return amount;
        }
        static void Main(string[] args)
        {
            int n;
            int amount = 0;
            Console.Write("Enter an integer number: ");
            n = int.Parse(Console.ReadLine());
            UniqueNumbers cdn = new UniqueNumbers();
            amount = cdn.FindUniqueNumbers(n);
            Console.WriteLine("Amount of different numbers is " +  amount);
            Console.ReadKey();
        }
    }
}
