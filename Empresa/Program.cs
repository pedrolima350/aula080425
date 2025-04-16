using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ClienteVIP vip1 = new ClienteVIP();
            vip1.criarCod("69");
            Console.WriteLine(vip1.Cod_vip);

            vip1.cadastrar();
            vip1.exibirInfo();


        }
    }
}
