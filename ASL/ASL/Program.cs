using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASL
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k,cf;
            k = 32768;
            i = int.Parse(Console.ReadLine());
            j = i;
            if ((j >= 16384 && j <= 32767) || (j >= 49152 && j <= 65535)){
                if (j >= 16384 && j <= 32767)
                {
                    i = i - 16384;
                    i = i << 1;
                }
                else{
                    i = i - 49152;
                    i = i << 1;
                    i = i + 32768;
                }
                cf = 1;

            }
            else{
                if (j < 16384)
                {
                    i = i << 1;
                }
                else {
                    i = i - 32768;
                    i = i << 1;
                    i = i + 32768;
                }
                cf = 0;
            }
            
            System.Console.WriteLine("ASL: " + i);
            System.Console.WriteLine("CF = " + cf);
        }
    }
}
