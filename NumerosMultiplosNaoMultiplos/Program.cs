using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosMultiplosNaoMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int n1 = int.Parse(valores[0]);
            int n2 = int.Parse(valores[1]);

            if (n1 % n2 == 0)
            {
                Console.WriteLine("SAO MULTIPLOS");

            }
            else { Console.WriteLine("Não SAO MULTIPLOS"); }

        }
    }
}
