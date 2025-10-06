using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Srarp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Введите A1:");
            double A1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите A2:");
            double A2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите A3:");
            double A3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите A4:");
            double A4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите A5:");
            double A5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите A6:");
            double A6 = Convert.ToDouble(Console.ReadLine());
           
            
            double r1 = test(A1);
            Console.WriteLine("Ответ"+r1);
            Console.ReadLine();
        }

        static double test(double result)
        {
            return result;
        }
    
        static double mediana(double x1, double x2, double x3, double y1, double y2, double y3)
         {
        return 1 / 2 * (x1 - x2) * (y3 - y1) - (x3 - x1) * (y2 - y1);
         }   
}   }
