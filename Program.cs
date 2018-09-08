using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_concat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ");
            Console.Write("Enter your first name ");
            string myfirstname;
            myfirstname = Console.ReadLine();
            Console.Write("Enter your last name ");
            string mylastname;
            mylastname = Console.ReadLine();
            Console.WriteLine("Hello  " + myfirstname + " " + mylastname);
            Console.ReadLine();

        }
    }
}
