using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDNotaFiscal.Model
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double ValorTotal { get; private set; }
        public int QuantidadeItens { get; private set; }

        public Pedido(string cliente, double valorToal, int quantidadeItens)
        {
            Cliente = cliente;
            ValorTotal = valorToal;
            QuantidadeItens = quantidadeItens;
        }
    }

    public class NotaFiscal
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }

        public NotaFiscal(string cliente, double valor, DateTime data)
        {
            Cliente = cliente;
            Valor = valor;
            Data = data;
        }
    }
}