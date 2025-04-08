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
            int tamanho = 5;
            int[] lista = new int[tamanho];
            int i;
            for (i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um valor:");
                lista[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < tamanho; i++)
            {
            Console.WriteLine("Valor:{0}", lista[i]);
            }
        }
    }
}
