namespace Projeto_Cantina
{
    partial class Balcao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balcao));
            lstBoxPedidosFeitos = new ListBox();
            lstBoxPedidosEntregues = new ListBox();
            btnEntregue = new Button();
            lblPedidosFeitos = new Label();
            lblPedidosEntregues = new Label();
            pictureBox1 = new PictureBox();
            lblDetalhes = new Label();
            lstBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstBoxPedidosFeitos
            // 
            lstBoxPedidosFeitos.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxPedidosFeitos.FormattingEnabled = true;
            lstBoxPedidosFeitos.Location = new Point(12, 157);
            lstBoxPedidosFeitos.Name = "lstBoxPedidosFeitos";
            lstBoxPedidosFeitos.Size = new Size(250, 260);
            lstBoxPedidosFeitos.TabIndex = 0;
            lstBoxPedidosFeitos.SelectedIndexChanged += lstBoxPedidosFeitos_SelectedIndexChanged;
            // 
            // lstBoxPedidosEntregues
            // 
            lstBoxPedidosEntregues.DrawMode = DrawMode.OwnerDrawFixed;
            lstBoxPedidosEntregues.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBoxPedidosEntregues.FormattingEnabled = true;
            lstBoxPedidosEntregues.Location = new Point(777, 157);
            lstBoxPedidosEntregues.Name = "lstBoxPedidosEntregues";
            lstBoxPedidosEntregues.Size = new Size(281, 260);
            lstBoxPedidosEntregues.TabIndex = 1;
            lstBoxPedidosEntregues.DrawItem += lstBoxPedidosEntregues_DrawItem;
            lstBoxPedidosEntregues.SelectedIndexChanged += lstBoxPedidosEntregues_SelectedIndexChanged;
            // 
            // btnEntregue
            // 
            btnEntregue.BackColor = SystemColors.ActiveCaptionText;
            btnEntregue.Font = new Font("Agrandir Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregue.ForeColor = Color.FromArgb(230, 255, 0);
            btnEntregue.Location = new Point(655, 249);
            btnEntregue.Name = "btnEntregue";
            btnEntregue.Size = new Size(86, 53);
            btnEntregue.TabIndex = 2;
            btnEntregue.Text = "PEDIDO ENTREGUE";
            btnEntregue.UseVisualStyleBackColor = false;
            btnEntregue.Click += btnEntregue_Click;
            // 
            // lblPedidosFeitos
            // 
            lblPedidosFeitos.AutoSize = true;
            lblPedidosFeitos.Font = new Font("Agrandir Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosFeitos.Location = new Point(59, 117);
            lblPedidosFeitos.Name = "lblPedidosFeitos";
            lblPedidosFeitos.Size = new Size(148, 28);
            lblPedidosFeitos.TabIndex = 3;
            lblPedidosFeitos.Text = "Pedidos Feitos";
            // 
            // lblPedidosEntregues
            // 
            lblPedidosEntregues.AutoSize = true;
            lblPedidosEntregues.Font = new Font("Agrandir Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosEntregues.Location = new Point(813, 117);
            lblPedidosEntregues.Name = "lblPedidosEntregues";
            lblPedidosEntregues.Size = new Size(187, 28);
            lblPedidosEntregues.TabIndex = 4;
            lblPedidosEntregues.Text = "Pedidos Entregues";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(624, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lblDetalhes
            // 
            lblDetalhes.AutoSize = true;
            lblDetalhes.Font = new Font("Agrandir Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalhes.Location = new Point(383, 117);
            lblDetalhes.Name = "lblDetalhes";
            lblDetalhes.Size = new Size(192, 28);
            lblDetalhes.TabIndex = 18;
            lblDetalhes.Text = "Detalhes do Pedido";
            // 
            // lstBox1
            // 
            lstBox1.Font = new Font("Agrandir Narrow", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBox1.FormattingEnabled = true;
            lstBox1.Location = new Point(327, 157);
            lstBox1.Name = "lstBox1";
            lstBox1.Size = new Size(281, 260);
            lstBox1.TabIndex = 19;
            // 
            // Balcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 460);
            Controls.Add(lstBox1);
            Controls.Add(lblDetalhes);
            Controls.Add(pictureBox1);
            Controls.Add(lblPedidosEntregues);
            Controls.Add(lblPedidosFeitos);
            Controls.Add(btnEntregue);
            Controls.Add(lstBoxPedidosEntregues);
            Controls.Add(lstBoxPedidosFeitos);
            Name = "Balcao";
            Text = "Balcão";
            Load += Balcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBoxPedidosFeitos;
        private ListBox lstBoxPedidosEntregues;
        private Button btnEntregue;
        private Label lblPedidosFeitos;
        private Label lblPedidosEntregues;
        private PictureBox pictureBox1;
        private Label lblDetalhes;
        private ListBox lstBox1;
    }
}