using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pessoa p1 = new pessoa();

            p1.cadastrar();

            p1.dados();
            p1.dados2();
            Console.ReadKey();
        }
    }
}
