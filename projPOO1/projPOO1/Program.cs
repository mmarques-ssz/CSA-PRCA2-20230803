using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soma s;
            s = new Soma();

            s.n1 = 5;
            s.n2 = 6;
            s.calcular();
            Console.WriteLine("A soma de {0} com {1} é {2}", 
                s.n1, s.n2, s.resultado);
        }
    }
}
