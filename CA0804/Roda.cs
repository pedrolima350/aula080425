using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0804
{
    class Roda
    {
      public  int aro;
      public  string material;
      public string posicao;

        public void cadastrar()
        {
            Console.WriteLine("Digite o material");
            this.material = Console.ReadLine();
            Console.WriteLine("Digite o tamanho do Aro");
            this.aro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite posicao da roda");
            this.posicao = Console.ReadLine();
        }

        public void exibir()
        {
            Console.WriteLine("Material:{0}",this.material);
            Console.WriteLine("Aro:{0}",this.aro);
            Console.WriteLine("Posição da Roda:{0}",this.posicao);
        }
    }
}
