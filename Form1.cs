namespace Projeto_Cantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

            string nomeCliente = txtNomeCliente.Text;
            string formaPagamento = comboPagamento.SelectedItem != null ? comboPagamento.SelectedItem.ToString() : "Não informado";
            string pedidoParaViagem = chkViagem.Checked ? "Sim" : "Não";

            string itens = "";
            decimal total = 0;
            foreach (Produto produto in listPedidos.Items)
            {
                itens += produto.ToString() + "\n";
                total += produto.preco;
            }

            string trocoTexto = "";
            if (formaPagamento == "Dinheiro")
            {
                if (decimal.TryParse(txtValorRecebido.Text, out decimal recebido))
                {
                    if (recebido >= total)
                    {
                        decimal troco = recebido - total;
                        txtTroco.Text = troco.ToString("F2");
                        trocoTexto = $"Valor Recebido: R${recebido:F2}\nTroco: R${troco:F2}\n\n";
                    }
                    else
                    {
                        MessageBox.Show("O valor recebido é menor que o total do pedido.", "Erro");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Digite um valor recebido válido.", "Erro");
                    return;
                }
            }

            string resumo = $"Cliente: {nomeCliente}\n\n" +
                            $"Itens do Pedido:\n{itens}\n" +
                            $"Para viagem: {pedidoParaViagem}\n" +
                            $"Pagamento: {formaPagamento}\n\n" +
                            trocoTexto +
                            $"Total: R${total:F2}";

            MessageBox.Show(resumo, "Resumo do Pedido");
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
    }
}
