using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k,cf;
            i = int.Parse(Console.ReadLine());
            j = i & 0x4000;
            k = i & 0x0001;
            if (k == 0x0001)
            {
                cf = 1;
            }
            else {
                cf = 0;
            }
            if (i >= 0x8000)
            {
                
                i = i >> 1;
                i += 0x8000;
                if(j == 0x0000){
                    i -= 0x4000;
                }
            }
            else {
                i = i >> 1;
                if(j == 0x4000){
                    j += 0x4000;
                }
            }
            Console.WriteLine("ASR: " + i);
            Console.WriteLine("CF:" + cf);
        }
    }
}
