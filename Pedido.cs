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

    public Pedido(string formaDePagamento, string nomeCliente, bool pedidoViagem, List<Produto> produtos)
        {
          FormaDePagamento= formaDePagamento;
          NomeCliente=nomeCliente;
          Produtos=produtos;
          PedidoViagem=pedidoViagem;            

        }
    public Pedido() 
        {
          FormaDePagamento ="";
          NomeCliente = "";
          Produtos=new List<Produto>();
          PedidoViagem = false;
        }
    }
}


