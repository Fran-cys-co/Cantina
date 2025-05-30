namespace Projeto_Cantina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listCardapio = new ListBox();
            listPedidos = new ListBox();
            btnAdicionar = new Button();
            listRemover = new Button();
            chkViagem = new CheckBox();
            comboPagamento = new ComboBox();
            txtNomeCliente = new TextBox();
            btnConcluir = new Button();
            label1 = new Label();
            labelNomeCliente = new Label();
            lblValorRecebido = new Label();
            lblTroco = new Label();
            txtValorRecebido = new TextBox();
            txtTroco = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listCardapio
            // 
            listCardapio.FormattingEnabled = true;
            listCardapio.ItemHeight = 15;
            listCardapio.Location = new Point(6, 97);
            listCardapio.Name = "listCardapio";
            listCardapio.Size = new Size(258, 289);
            listCardapio.TabIndex = 0;
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.ItemHeight = 15;
            listPedidos.Location = new Point(487, 97);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(290, 289);
            listPedidos.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = SystemColors.Info;
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.Blue;
            btnAdicionar.Location = new Point(270, 97);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(87, 30);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listRemover
            // 
            listRemover.BackColor = SystemColors.Info;
            listRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listRemover.ForeColor = Color.Red;
            listRemover.Location = new Point(398, 355);
            listRemover.Name = "listRemover";
            listRemover.Size = new Size(83, 31);
            listRemover.TabIndex = 3;
            listRemover.Text = "REMOVER";
            listRemover.UseVisualStyleBackColor = false;
            listRemover.Click += listRemover_Click;
            // 
            // chkViagem
            // 
            chkViagem.AutoSize = true;
            chkViagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkViagem.Location = new Point(817, 164);
            chkViagem.Name = "chkViagem";
            chkViagem.Size = new Size(136, 19);
            chkViagem.TabIndex = 4;
            chkViagem.Text = "Pedido Para Viagem";
            chkViagem.UseVisualStyleBackColor = true;
            // 
            // comboPagamento
            // 
            comboPagamento.BackColor = SystemColors.Window;
            comboPagamento.FormattingEnabled = true;
            comboPagamento.Items.AddRange(new object[] { "Cartão Crédito", "Cartão Débito", "Dinheiro", "PIX" });
            comboPagamento.Location = new Point(143, 423);
            comboPagamento.Name = "comboPagamento";
            comboPagamento.Size = new Size(121, 23);
            comboPagamento.TabIndex = 5;
            comboPagamento.SelectedIndexChanged += comboPagamento_SelectedIndexChanged;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.Window;
            txtNomeCliente.Location = new Point(802, 344);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(161, 23);
            txtNomeCliente.TabIndex = 6;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // btnConcluir
            // 
            btnConcluir.BackColor = Color.DarkGray;
            btnConcluir.Font = new Font("Britannic Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConcluir.ForeColor = Color.Lime;
            btnConcluir.Location = new Point(827, 445);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(96, 65);
            btnConcluir.TabIndex = 7;
            btnConcluir.Text = "Concluir \r\n Pedido";
            btnConcluir.UseVisualStyleBackColor = false;
            btnConcluir.Visible = false;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 426);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 10;
            label1.Text = "Forma de Pagamento";
            label1.UseMnemonic = false;
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomeCliente.Location = new Point(827, 326);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(111, 15);
            labelNomeCliente.TabIndex = 11;
            labelNomeCliente.Text = "NOME DO CLIENTE";
            labelNomeCliente.UseMnemonic = false;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.Location = new Point(396, 431);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(85, 15);
            lblValorRecebido.TabIndex = 12;
            lblValorRecebido.Text = "Valor Recebido";
            // 
            // lblTroco
            // 
            lblTroco.AutoSize = true;
            lblTroco.Location = new Point(434, 495);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(37, 15);
            lblTroco.TabIndex = 13;
            lblTroco.Text = "Troco";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Location = new Point(487, 431);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.Size = new Size(108, 23);
            txtValorRecebido.TabIndex = 14;
            // 
            // txtTroco
            // 
            txtTroco.Location = new Point(487, 487);
            txtTroco.Name = "txtTroco";
            txtTroco.ReadOnly = true;
            txtTroco.Size = new Size(108, 23);
            txtTroco.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(853, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 535);
            Controls.Add(pictureBox1);
            Controls.Add(txtTroco);
            Controls.Add(txtValorRecebido);
            Controls.Add(lblTroco);
            Controls.Add(lblValorRecebido);
            Controls.Add(labelNomeCliente);
            Controls.Add(label1);
            Controls.Add(btnConcluir);
            Controls.Add(txtNomeCliente);
            Controls.Add(comboPagamento);
            Controls.Add(chkViagem);
            Controls.Add(listRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listPedidos);
            Controls.Add(listCardapio);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCardapio;
        private ListBox listPedidos;
        private Button btnAdicionar;
        private Button listRemover;
        private CheckBox chkViagem;
        private ComboBox comboPagamento;
        private TextBox txtNomeCliente;
        private Button btnConcluir;
        private Label label1;
        private Label labelNomeCliente;
        private Label lblValorRecebido;
        private Label lblTroco;
        private TextBox txtValorRecebido;
        private TextBox txtTroco;
        private PictureBox pictureBox1;
    }
}
