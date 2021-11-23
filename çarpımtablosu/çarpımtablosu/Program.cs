using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çarpımtablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(a + "x" + j + "=" + (a * j));
                }
            }
            Console.ReadLine();
        }
    }
}
