
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v;
            double total;
            int k;

            total = 0;
            k = 1;
            do
            {
                Console.Write("Digite o valor: ");
                v = double.Parse(Console.ReadLine());
                total = total + v;
                k = k + 1;
            }
            while (v > 0);

        }
    }
}
