//Даны переменные A, B, C. Изменить их значения, переместив содержимое A в C, C — в B, B — в A, и вывести новые значения переменных A,B, C.
using System;

namespace DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the variable a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the variable b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the variable c");
            c = Convert.ToDouble(Console.ReadLine());
            (a, b, c) = (b, c, a);
            Console.WriteLine((a, b, c));

        }
    }
}
