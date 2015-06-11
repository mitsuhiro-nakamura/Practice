using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            var i = int.Parse(Console.ReadLine());
            var str = Console.ReadLine();
            switch(i){
                case 1:
                    s = Convert.ToInt32(str, 16);   //16進数から10進数へ
                    Console.WriteLine(s);
                    break;
                case 2:
                    s = Convert.ToInt32(str,2);     //2進数から10進数へ
                    Console.WriteLine(s);
                    break;
                case 3:
                    s = Convert.ToInt32(str, 2);
                    Console.WriteLine(s.ToString("x4"));    //2進数から16進数へ
                    break;
                case 4:
                    s = Convert.ToInt32(str, 10);
                    string a = Convert.ToString(s, 16);    //10進数から16進数へ
                    Console.WriteLine(a);
                    break;
                case 5:
                    s = Convert.ToInt32(str, 10);
                    string b = Convert.ToString(s, 2);     //10進数から2進数へ
                    Console.WriteLine(b);
                    break;
                case 6:
                    string c =Convert.ToString(Convert.ToInt32(str,16),2);  //16進数から2進数へ
                    Console.WriteLine(c);
                    break;
            }
        }
    }
}
