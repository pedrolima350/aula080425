using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0804
{
    class Program
    {
        static void Main(string[] args)
        {
          Carro fusca = new Carro();

            fusca.rodas[0] = new Roda();
            fusca.rodas[0].cadastrar();
            fusca.rodas[0].exibir();

        }
    }
}
