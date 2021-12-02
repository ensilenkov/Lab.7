using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double max = SqTr(a1, b1, c1, a2, b2, c2);

            Console.WriteLine(max);
            Console.ReadKey();
        }
        static double SqTr(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            double p1 = (a1 + b1 + c1) / 2;
            double s1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            double p2 = (a2 + b2 + c2) / 2;
            double s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            double max = Math.Max(s1, s2);
            return max;
        }
    }
}
