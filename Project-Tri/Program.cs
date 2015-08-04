using com.mindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GeomUtils.CalculateRightTriangleArea(3, -4, 5));
            Console.ReadLine();
        }
    }
}
