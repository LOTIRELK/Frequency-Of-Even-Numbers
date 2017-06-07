using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a program that reads a list of integers and computes the frequency of even numbers.
//the program exits when an integer entered equals -1.
namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare integers for value entered and a counter
            int value;
            int counter = 0;
            Console.WriteLine("Please enter a list of integers.");
            do
            {
                string input = Console.ReadLine();//take in the value entered
                int.TryParse(input, out value);//convert to int variable named value
                if (value % 2 == 0)//check if the value is even
                {
                    counter += 1;//add one to counter
                }
            } while (value != -1);//continue loop until the value entered is -1
            Console.WriteLine("The frequency of even nubers is " + counter);//output result
        }
    }
}
