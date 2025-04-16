using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Pessoa
    {
        protected string nome;
        protected string email;
        public string telefone;

        public void exibirInfo()
        {
            Console.WriteLine("Nome:{0} Email:{1}", this.Nome, this.Email);
        }

        public virtual void cadastrar()
        {
            Console.WriteLine("Digite o nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite o email: ");
            this.Email = Console.ReadLine();
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome inválido");
                    nome = "Nome inválido";
                }
                else
                {
                    nome = value.ToUpper();
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains("@")) { 
                    email = value;
                }
                else
                {
                    Console.WriteLine("");
                }
               
            }

        }
        
    }
}
