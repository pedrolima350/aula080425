using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Cliente : Pessoa
    {
        protected int ID;


        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite o ID do cliente: ");
            this.ID = int.Parse(Console.ReadLine());
        }


    }
}
