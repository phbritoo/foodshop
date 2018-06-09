namespace AplicacaoFoodShop
{
    partial class Carrinho
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.listViewNota = new System.Windows.Forms.ListView();
            this.Qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.textBoxBandeira = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewNota
            // 
            this.listViewNota.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Qtd,
            this.Produto,
            this.Descricao,
            this.Marca,
            this.Valor,
            this.Loja});
            this.listViewNota.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewNota.Location = new System.Drawing.Point(61, 360);
            this.listViewNota.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listViewNota.Name = "listViewNota";
            this.listViewNota.Size = new System.Drawing.Size(1411, 455);
            this.listViewNota.TabIndex = 38;
            this.listViewNota.UseCompatibleStateImageBehavior = false;
            this.listViewNota.View = System.Windows.Forms.View.Details;
            this.listViewNota.SelectedIndexChanged += new System.EventHandler(this.listViewNota_SelectedIndexChanged);
            // 
            // Qtd
            // 
            this.Qtd.Text = "Qtd";
            this.Qtd.Width = 100;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 227;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descricao";
            this.Descricao.Width = 254;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 307;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor Unitario";
            this.Valor.Width = 337;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 857);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 55);
            this.label4.TabIndex = 37;
            this.label4.Text = "Preco Total: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 865);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 38);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1256, 856);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 35;
            this.button1.Text = "voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(744, 856);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(200, 55);
            this.buttonListar.TabIndex = 34;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // textBoxBandeira
            // 
            this.textBoxBandeira.Location = new System.Drawing.Point(1167, 268);
            this.textBoxBandeira.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxBandeira.Name = "textBoxBandeira";
            this.textBoxBandeira.Size = new System.Drawing.Size(305, 38);
            this.textBoxBandeira.TabIndex = 33;
            this.textBoxBandeira.TextChanged += new System.EventHandler(this.textBoxBandeira_TextChanged);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(374, 277);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(305, 38);
            this.textBoxNumero.TabIndex = 32;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.textBoxNumero_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(721, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 55);
            this.label3.TabIndex = 31;
            this.label3.Text = "Numero do Carrinnho:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 55);
            this.label2.TabIndex = 30;
            this.label2.Text = "Usuario Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 132);
            this.label1.TabIndex = 29;
            this.label1.Text = "Seu Carrinho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loja
            // 
            this.Loja.Text = "Loja";
            this.Loja.Width = 150;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacaoFoodShop.Properties.Resources.telafundo;
            this.ClientSize = new System.Drawing.Size(1525, 1060);
            this.Controls.Add(this.listViewNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.textBoxBandeira);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNota;
        public System.Windows.Forms.ColumnHeader Qtd;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.TextBox textBoxBandeira;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Loja;
    }
}