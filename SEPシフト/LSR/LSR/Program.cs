using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSR
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, cf;
            i = int.Parse(Console.ReadLine());
            j = i & 0x0001;
            i = i >> 1;
            if (j == 0x0001)
            {
                cf = 1;
            }
            else {
                cf = 0;
            }
            Console.WriteLine("LSR: " + i);
            Console.WriteLine("CF: " + cf);
        }
    }
}
