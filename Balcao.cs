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
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();
            lstBoxPedidosEntregues.DrawItem += lstBoxPedidosEntregues_DrawItem;
            lstBoxPedidosEntregues.DrawMode = DrawMode.OwnerDrawFixed; // necessário para customizar cores
        }

        public void AdicionarPedido(string textoPedido)
        {
            lstBoxPedidosFeitos.Items.Add(textoPedido);
        }

        private void lstBoxPedidosFeitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxPedidosFeitos.SelectedItem != null)
            {
                MostrarDetalhesPedido(lstBoxPedidosFeitos.SelectedItem.ToString());
            }
        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {
            if (lstBoxPedidosFeitos.SelectedItem != null)
            {
                string pedido = lstBoxPedidosFeitos.SelectedItem.ToString();

                lstBoxPedidosEntregues.Items.Add(pedido);
                lstBoxPedidosFeitos.Items.Remove(pedido);

                lstBox1.Items.Clear(); // limpa a visualização ao marcar como entregue
            }
            else
            {
                MessageBox.Show("Selecione um pedido para marcar como entregue.");
            }
        }

        private void lstBoxPedidosEntregues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxPedidosEntregues.SelectedItem != null)
            {
                MostrarDetalhesPedido(lstBoxPedidosEntregues.SelectedItem.ToString());
            }
        }

        private void MostrarDetalhesPedido(string pedidoBruto)
        {
            lstBox1.Items.Clear();

            string[] partes = pedidoBruto.Split('|');

            string cliente = partes.Length > 0 ? partes[0].Replace("Cliente:", "").Trim() : "";
            string itens = partes.Length > 1 ? partes[1].Trim() : "";

            lstBox1.Items.Add($"Pedido: {cliente}");

            if (itens.Contains("Itens:"))
            {
                string listaItens = itens.Replace("Itens:", "").Trim();
                string[] itensSeparados = listaItens.Split(',');

                foreach (string item in itensSeparados)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        lstBox1.Items.Add($"    {item.Trim()}");
                    }
                }
            }
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
