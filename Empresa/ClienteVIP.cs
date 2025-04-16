using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class ClienteVIP : Cliente
    {
        protected string cod_vip;
        protected double desconto;
        protected double cashback;
        protected int pontos;


        public void criarCod(string cod)
        {
            this.cod_vip = cod;
        }
        
        public string Cod_vip
        {
            get
            {
                return cod_vip;
            }
        }
        public void definirCashback(double cash)
        {
            if (cash < 1)
            {
                this.cashback = 1;
            }
            else
            {
                this.cashback = cash;
            }
        }

        public void calcularDesconto()
        {

        }


        public double calcularCashback(double valor_compra)
        {
            double valor = valor_compra * cashback;
            return valor;
        }




        }

    }
