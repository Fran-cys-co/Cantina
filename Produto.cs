using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cantina
{
    public class Produto
    {
        public string nome { get; set; }
        public decimal preco { get; set; }

        public Produto(string nome, decimal preco)
        { 
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString()
        {
            return $"{nome} - R$ {preco}";
        }
    }


}
