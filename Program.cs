using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstSharpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            int triangleBase = 5, height = 6;
            double triangleArea = 0;
            triangleArea = 0.5 * (triangleBase * height);
            bool isCSharpFun = true;

            Console.WriteLine("Hello there!");
            Console.WriteLine("The value of PI is:" + pi);
            Console.WriteLine("The area of this triangle is: " + triangleArea);
            Console.WriteLine($"Is C# fun? : {isCSharpFun}");
            Console.WriteLine("Int to string conversion => triangleArea is: " + Convert.ToString(triangleBase));
            Console.WriteLine("What is your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Welcome, " + firstName);
            Console.WriteLine("The length of your name is: " + firstName.Length);
            Console.WriteLine("Your capitalised name is: " + firstName.ToUpper());

            Console.WriteLine("What is your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Your full name is:{firstName.ToUpper()} {lastName.ToUpper()}");
            Console.WriteLine($"The second part of your last name starting from letter 'z' is: {lastName.Substring(lastName.IndexOf("z"))}");

            int x = 10;
            int y = 13;
            Console.WriteLine("The result is: " + x * y / x);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
