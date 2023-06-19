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
            
            Console.WriteLine("Hello there!");
            Console.WriteLine("The value of PI is:" + pi);
            Console.WriteLine("The area of this triangle is: " + triangleArea);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
