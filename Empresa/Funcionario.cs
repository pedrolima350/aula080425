using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Funcionario : Pessoa
    {
        protected double salario;
        public Pessoa[] dependentes = new Pessoa[5];
        public int registro;
        public string cargo;

        public Funcionario(string nome,double sal)
        {
            this.nome = nome;
            this.salario = sal;
        }
        public Funcionario() { 
        
        }
        public Funcionario(string nome)
        {
            this.nome = nome;
        }

        public void adicionarDependente(string nomeDependente)
        {
            this.dependentes[5] = new Pessoa();
            this.dependentes[0].cadastrar();

        }

        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("Digite o registro: ");
            this.registro = int.Parse(Console.ReadLine());
        }

        public void registrarSalario(double sal)
        {
            if (sal == 0 || sal<0 || sal<1499)
            {
                this.salario = 1500;
            }
            else
            {
                this.salario = sal;
            }
        }

        public void exibir()
        {
            Console.WriteLine("Registro:{0} \nNome:{1} Salario:{2} \n Dependentes: {3}",this.registro,this.nome,this.salario, this.dependentes[0]);
        }


    }
}
