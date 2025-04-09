using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Funcionario : Pessoa
    {
        protected double salario;
        public string cargo;
        public Pessoa[] dependentes = new Pessoa[5];
        private string senha;

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

        public void cadastrarSenha(string senha)
        {
            this.senha = senha;
        }

        public void exibir()
        {
            Console.WriteLine("Nome:{0}\nSalario:{1}",this.nome,this.salario);
        }
    }
}
