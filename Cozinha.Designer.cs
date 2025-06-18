namespace Projeto_Cantina
{
    partial class Cozinha
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
            listBox1 = new ListBox();
            btnPronto = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(25, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(722, 154);
            listBox1.TabIndex = 0;
            // 
            // btnPronto
            // 
            btnPronto.Font = new Font("Agrandir Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPronto.Location = new Point(286, 230);
            btnPronto.Name = "btnPronto";
            btnPronto.Size = new Size(153, 34);
            btnPronto.TabIndex = 1;
            btnPronto.Text = "Pedido Pronto";
            btnPronto.UseVisualStyleBackColor = true;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPronto);
            Controls.Add(listBox1);
            Name = "Cozinha";
            Text = "Status";
            Load += Cozinha_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnPronto;
    }
}