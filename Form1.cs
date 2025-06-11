using System.Diagnostics.Eventing.Reader;

namespace Projeto_Cantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Balcao form2 = new Balcao();
        private void Form1_Load(object sender, EventArgs e)
        {
            listCardapio.Items.Add(new Produto("Pão de Queijo", 3.50m));
            listCardapio.Items.Add(new Produto("Coxinha", 5.00m));
            listCardapio.Items.Add(new Produto("Pastel de Carne", 6.00m));
            listCardapio.Items.Add(new Produto("Pastel de Queijo", 5.50m));
            listCardapio.Items.Add(new Produto("Suco Natural 300 ml", 4.00m));
            listCardapio.Items.Add(new Produto("Refrigerante Lata", 3.50m));
            listCardapio.Items.Add(new Produto("Hambúrguer Simples", 8.00m));
            listCardapio.Items.Add(new Produto("Hambúrguer Com Queijo", 9.00m));
            listCardapio.Items.Add(new Produto("X-Tudo", 12.00m));
            listCardapio.Items.Add(new Produto("Água Mineral", 2.50m));

            txtValorRecebido.Visible = false;
            txtTroco.Visible = false;
        }

        private void comboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPagamento.SelectedItem != null && comboPagamento.SelectedItem.ToString() == "Dinheiro")
            {
                txtValorRecebido.Visible = true;
                txtTroco.Visible = true;
            }
            else
            {
                txtValorRecebido.Visible = false;
                txtTroco.Visible = false;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listCardapio.SelectedItem != null)
            {
                listPedidos.Items.Add(listCardapio.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um item do cardápio.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listPedidos.SelectedItem != null)
            {
                listPedidos.Items.Remove(listPedidos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione o item que você quer remover.");
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            btnConcluir.Visible = !string.IsNullOrWhiteSpace(txtNomeCliente.Text);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            
            if (listPedidos.Items.Count == 0)
            {
                MessageBox.Show("Nenhum item foi adicionado ao pedido.");
                return;
            }

            Pedido novoPedido = new Pedido
            {
                NomeCliente = txtNomeCliente.Text,
                FormaDePagamento = comboPagamento.SelectedItem?.ToString() ?? "Não informado",
                PedidoViagem = chkViagem.Checked,
                Produtos = new List<Produto>()
            };

            foreach (Produto p in listPedidos.Items)
            {
                novoPedido.Produtos.Add(p);
            }

            form2.AdicionarPedido(novoPedido);

            // Zera os campos
            listPedidos.Items.Clear();
            txtNomeCliente.Clear();
            comboPagamento.SelectedIndex = -1;
            txtValorRecebido.Clear();
            txtTroco.Clear();
            chkViagem.Checked = false;
        }

        
        private void listRemover_Click(object sender, EventArgs e)
        {
            if (listPedidos.SelectedItem != null)
            {
                listPedidos.Items.Remove(listPedidos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um item da lista de pedidos para remover.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Balcao();
            }
            form2.Show();
        }
       

    }
}
