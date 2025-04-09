using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Gerente : Funcionario
    {
        public string setor;

        public void salarioGerente(double sal)
        {
            if (sal > 2000 && sal < 4000)
            {
                this.salario = sal;
            }

        }
    }
}
