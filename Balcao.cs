using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
        private Form2 formBalcao;
        private void Form2_Load(object sender, EventArgs e)
        {   
        }
        public void AdicionarPedido(string textoPedido)
        {
            lstBoxPedidosFeitos.Items.Add(textoPedido);
        }

        private void lstBoxPedidosEntregues_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEntregue_Click(object sender, EventArgs e)
        {
            if (lstBoxPedidosFeitos.SelectedItem != null)
            {
                string pedido = lstBoxPedidosFeitos.SelectedItem.ToString();
                lstBoxPedidosEntregues.Items.Add(pedido);
                lstBoxPedidosFeitos.Items.Remove(lstBoxPedidosFeitos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um pedido para marcar como entregue.");
            }
        }

        private void lblPedidosEntregues_Click(object sender, EventArgs e)
        {

        }
    }
}

