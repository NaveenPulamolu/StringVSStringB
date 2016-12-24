using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVSStringBuildrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            str += "How are you";
            str += "Doing?";// new Instance will be created every time
            Console.WriteLine(str);
            str = "Naveen";// Erasing the old instance and adding new value to it
            Console.WriteLine(str); 
            StringBuilder buildr = new StringBuilder("");
            buildr.Append("I am ");
            buildr.Append("Doing great,");
            buildr.Append("Thank you");
            // new Instance will not be created every time
            Console.WriteLine(buildr);

            string returnNumber = "";
            for (int i = 0; i < 10; i++)
            {
                returnNumber = returnNumber + i.ToString();
            }
            // new Instance will be created every time
            Console.WriteLine(returnNumber);
            returnNumber = "941464768"; // Erasing the old instance and adding new value to it
            Console.WriteLine(returnNumber);
            StringBuilder returnNumber1 = new StringBuilder(10);
            for (int i = 0; i < 10; i++)
            {
                returnNumber1.Append(i.ToString());
            }
            // new Instance will not be created every time
            Console.WriteLine(returnNumber1);

            Console.ReadLine();

        }
    }
}
