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
            Funcionario f1 = new Funcionario("Zezinho",1000);
            Funcionario f2 = new Funcionario("Huguinho");
            Funcionario f3 = new Funcionario();

            f1.exibir();
            f2.exibir();
            f3.exibir();
        }
    }
}
