using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cantina
{
    public class Pedido
    {

        public List<Produto> Produtos { get; set; }
        public string FormaDePagamento { get; set; }
        public string NomeCliente { get; set; }
        public bool PedidoViagem { get; set; }
        public Status status { get; set; }

        public Pedido()
        {
            FormaDePagamento = "";
            NomeCliente = "";
            Produtos = new List<Produto>();
            PedidoViagem = false;
            status = Status.PREPARANDO;
        }
    }
}


