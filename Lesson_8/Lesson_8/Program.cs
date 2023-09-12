using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "1";
            int repeat = 3;
            string sss = "";
            for (int i = 0; i < repeat; i++)
            {
                 sss += name;
            }

            

            Console.WriteLine(sss);

            Console.ReadLine();
            
        }
    }
}
