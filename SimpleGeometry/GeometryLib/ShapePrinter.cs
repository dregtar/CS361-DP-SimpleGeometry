using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using GeometryLib.Shapes;

namespace GeometryLib
{
    public static class ShapePrinter
    {
        public static void Print(IPrintable IP)
        {
            string res = IP.Print();
            Console.WriteLine(res);
        }
    }
}
