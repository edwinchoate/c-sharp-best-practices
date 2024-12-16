using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    class Program
    {

        public const int ConstantNum = 100;
        public static readonly int ReadonlyNum = 0;

        static Program ()
        {
            ReadonlyNum = 9;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConstantNum);
            Console.WriteLine(ReadonlyNum);
            //ConstantVar = 9;
            //ReadonlyVar = 9;
        }
    }
}
