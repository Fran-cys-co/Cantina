using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cantina
{
    public partial class Balcao : Form
    {
        public List<Pedido> pedidosFeitos = new List<Pedido>();
        public List<Pedido> pedidosEntregues = new List<Pedido>();
        public Balcao()
        {
            InitializeComponent();
            lstBoxPedidosEntregues.DrawItem += lstBoxPedidosEntregues_DrawItem;
            lstBoxPedidosEntregues.DrawMode = DrawMode.OwnerDrawFixed; // customizar cores
        }

        public void AdicionarPedido(Pedido pedido)
        {
            pedidosFeitos.Add(pedido);
            lstBoxPedidosFeitos.Items.Add($"Cliente: {pedido.NomeCliente}");
        }

        public void lstBoxPedidosFeitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBoxPedidosFeitos.SelectedIndex;
            if (index >= 0 && index < pedidosFeitos.Count)
            {
                MostrarDetalhesPedido(pedidosFeitos[index]);
            }
        }


        private void btnEntregue_Click(object sender, EventArgs e)
        {
            int index = lstBoxPedidosFeitos.SelectedIndex;
            if (index >= 0 && index < pedidosFeitos.Count)
            {
                Pedido pedidoEntregue = pedidosFeitos[index];
                pedidosFeitos.RemoveAt(index);
                lstBoxPedidosFeitos.Items.RemoveAt(index);

                pedidosEntregues.Add(pedidoEntregue);
                lstBoxPedidosEntregues.Items.Add($"Cliente: {pedidoEntregue.NomeCliente}");

                lstBox1.Items.Clear(); 
            }
            else
            {
                MessageBox.Show("Selecione um pedido para marcar como entregue.");
            }
        }

        public void lstBoxPedidosEntregues_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBoxPedidosEntregues.SelectedIndex;
            if (index >= 0 && index < pedidosEntregues.Count)
            {
                MostrarDetalhesPedido(pedidosEntregues[index]);
            }
        }

        public void MostrarDetalhesPedido(Pedido pedido)
        {
            lstBox1.Items.Clear();
            lstBox1.Items.Add($"Cliente: {pedido.NomeCliente}");
            lstBox1.Items.Add($"Pedido:");

            foreach (Produto produto in pedido.Produtos)
            {
                lstBox1.Items.Add($"    {produto.nome}");
            }

            lstBox1.Items.Add($"Forma de Pagamento: {pedido.FormaDePagamento}");
        }

        private void lstBoxPedidosEntregues_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string texto = lstBoxPedidosEntregues.Items[e.Index].ToString();

            Brush corTexto = Brushes.Green;

            e.DrawBackground();
            e.Graphics.DrawString(texto, e.Font, corTexto, e.Bounds);
            e.DrawFocusRectangle();
        }


    }
}
