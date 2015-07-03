using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROR
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, cf;
            i = int.Parse(Console.ReadLine());
            j = i & 0x0001;
            i = i >> 1;
            if(j == 0x0001){
                i = i + 0x8000;
                cf = 1;
            }
            else{
                cf = 0;
            }
            Console.WriteLine("ROR: " + i);
            Console.WriteLine("CF: " + cf);
        }
    }
}
