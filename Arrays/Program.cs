using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare array and whatever is inside of it
            int[] myNumbers = { 10, 20, 30, 40 };
            string[] cars = { "voltswagon", "volvo", "ford", "bmw", "toyota" };
            //print out the specified number remember it goes from 0 to infinity not 1 to infinity
            Console.WriteLine(cars[0] + " " + myNumbers[1]);
            //replace a variable in the array
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
        }
    }
}
