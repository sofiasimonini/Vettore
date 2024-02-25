using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettore v1 = new Vettore(4, 5);
            Vettore v2 = new Vettore(6, 7);
            double s = 10;
            Console.WriteLine(v1+v2);
            Console.WriteLine(v1-v2);
            Console.WriteLine(v1*v2);
            Console.WriteLine(v1*s);
            Console.WriteLine(s*v1);
            Console.WriteLine(v1/s);
            Console.WriteLine(+v1);
            Console.WriteLine(-v1);
            Console.ReadLine();
        }
    }
}
