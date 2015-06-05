using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Converter
    {
        static void Main(string[] args)
        {
            string s;

            // 10進数→2進数へと変換する
            s = Convert.ToString(128, 2);
            Console.WriteLine(s);
        }
    }
}
