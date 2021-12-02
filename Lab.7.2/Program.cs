using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int s, v;
            Cube(a, out s, out v);
            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.ReadKey();
        }
        static void Cube(int a, out int s, out int v)
        {
            s = a * a * 6;
            v = a * a * a;
            
        }
    }
}
