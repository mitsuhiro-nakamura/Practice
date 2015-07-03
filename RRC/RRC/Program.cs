using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRC
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, cf = 0;
            i = int.Parse(Console.ReadLine());
            j = i & 0x0001;
            i = i >> 1;
            if (cf == 1) {
                i = i + 0x8000;
            }
            if (j == 0x0001)
            {
                cf = 1;
            }
            else {
                cf = 0;
            }
            Console.WriteLine("RRC: " + i);
            Console.WriteLine("CF: " + cf);
        }
    }
}
