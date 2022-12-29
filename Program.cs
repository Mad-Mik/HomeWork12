using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("number 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("number 2");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("number 3");
            thirdValue = double.Parse(Console.ReadLine());

            double sumResult = firstValue + secondValue + thirdValue;
            double multResult = firstValue * secondValue * thirdValue;

            Console.WriteLine("SumValue = " + sumResult);
            Console.WriteLine("MultValue = " + multResult);
        }
    }
}
