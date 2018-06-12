namespace AplicacaoFoodShop
{
    partial class Dashboard
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
            this.inputPesquisaProduto = new System.Windows.Forms.TextBox();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.listViewProdutoLoja = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputQtdItemsCarrinho = new System.Windows.Forms.TextBox();
            this.pesquisaLabel = new System.Windows.Forms.Label();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.removerButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // inputPesquisaProduto
            // 
            this.inputPesquisaProduto.Location = new System.Drawing.Point(111, 15);
            this.inputPesquisaProduto.Name = "inputPesquisaProduto";
            this.inputPesquisaProduto.Size = new System.Drawing.Size(525, 20);
            this.inputPesquisaProduto.TabIndex = 0;
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Location = new System.Drawing.Point(669, 15);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(97, 22);
            this.pesquisarButton.TabIndex = 1;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisarButton_Click);
            // 
            // listViewProdutoLoja
            // 
            this.listViewProdutoLoja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Produto,
            this.Descrição,
            this.Loja,
            this.Preço});
            this.listViewProdutoLoja.FullRowSelect = true;
            this.listViewProdutoLoja.Location = new System.Drawing.Point(111, 59);
            this.listViewProdutoLoja.Name = "listViewProdutoLoja";
            this.listViewProdutoLoja.Size = new System.Drawing.Size(525, 220);
            this.listViewProdutoLoja.TabIndex = 9;
            this.listViewProdutoLoja.UseCompatibleStateImageBehavior = false;
            this.listViewProdutoLoja.View = System.Windows.Forms.View.Details;
            // 
            // Produto
            // 
            this.Produto.DisplayIndex = 1;
            this.Produto.Text = "Produto";
            this.Produto.Width = 143;
            // 
            // Descrição
            // 
            this.Descrição.DisplayIndex = 2;
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 148;
            // 
            // Loja
            // 
            this.Loja.DisplayIndex = 3;
            this.Loja.Text = "Loja";
            this.Loja.Width = 148;
            // 
            // Preço
            // 
            this.Preço.DisplayIndex = 4;
            this.Preço.Text = "Preço";
            this.Preço.Width = 137;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ver carrinho completo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quantidade de items no carrinho";
            // 
            // inputQtdItemsCarrinho
            // 
            this.inputQtdItemsCarrinho.Location = new System.Drawing.Point(435, 302);
            this.inputQtdItemsCarrinho.Name = "inputQtdItemsCarrinho";
            this.inputQtdItemsCarrinho.Size = new System.Drawing.Size(45, 20);
            this.inputQtdItemsCarrinho.TabIndex = 12;
            // 
            // pesquisaLabel
            // 
            this.pesquisaLabel.AutoSize = true;
            this.pesquisaLabel.Location = new System.Drawing.Point(-2, 18);
            this.pesquisaLabel.Name = "pesquisaLabel";
            this.pesquisaLabel.Size = new System.Drawing.Size(109, 13);
            this.pesquisaLabel.TabIndex = 13;
            this.pesquisaLabel.Text = "Pesquise um produto:";
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(669, 59);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(97, 22);
            this.adicionarButton.TabIndex = 14;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(669, 105);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(97, 20);
            this.removerButton.TabIndex = 15;
            this.removerButton.Text = "Remover";
            this.removerButton.UseVisualStyleBackColor = true;
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(669, 350);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(97, 23);
            this.voltarButton.TabIndex = 16;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // ID
            // 
            this.ID.DisplayIndex = 0;
            this.ID.Text = "ID";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.pesquisaLabel);
            this.Controls.Add(this.inputQtdItemsCarrinho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewProdutoLoja);
            this.Controls.Add(this.pesquisarButton);
            this.Controls.Add(this.inputPesquisaProduto);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPesquisaProduto;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.ListView listViewProdutoLoja;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader Loja;
        private System.Windows.Forms.ColumnHeader Preço;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputQtdItemsCarrinho;
        private System.Windows.Forms.Label pesquisaLabel;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.ColumnHeader ID;
    }
}