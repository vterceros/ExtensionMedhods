using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPart.Library;
using MyExtension.Library;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations ope = new Operations();
            Console.WriteLine("Existing Method");
            Console.WriteLine(ope.CalculateArea(2, 2));
            Console.WriteLine("Extended Method");
            Console.WriteLine(ope.CalculateVolume(2, 2, 2));
            Console.ReadKey();
        }
    }
}
