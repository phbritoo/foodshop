namespace AplicacaoFoodShop
{
    partial class ProdutoLoja
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
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.comboBoxLoja = new System.Windows.Forms.ComboBox();
            this.inputPreco = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewProdutoLoja = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(134, 42);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduto.TabIndex = 0;
            // 
            // comboBoxLoja
            // 
            this.comboBoxLoja.FormattingEnabled = true;
            this.comboBoxLoja.Location = new System.Drawing.Point(134, 82);
            this.comboBoxLoja.Name = "comboBoxLoja";
            this.comboBoxLoja.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoja.TabIndex = 1;
            // 
            // inputPreco
            // 
            this.inputPreco.Location = new System.Drawing.Point(134, 120);
            this.inputPreco.Name = "inputPreco";
            this.inputPreco.Size = new System.Drawing.Size(121, 20);
            this.inputPreco.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(153, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 27);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Associar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listViewProdutoLoja
            // 
            this.listViewProdutoLoja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Produto,
            this.Loja,
            this.Preço});
            this.listViewProdutoLoja.FullRowSelect = true;
            this.listViewProdutoLoja.Location = new System.Drawing.Point(324, 24);
            this.listViewProdutoLoja.Name = "listViewProdutoLoja";
            this.listViewProdutoLoja.Size = new System.Drawing.Size(347, 163);
            this.listViewProdutoLoja.TabIndex = 8;
            this.listViewProdutoLoja.UseCompatibleStateImageBehavior = false;
            this.listViewProdutoLoja.View = System.Windows.Forms.View.Details;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 143;
            // 
            // Loja
            // 
            this.Loja.Text = "Loja";
            this.Loja.Width = 148;
            // 
            // Preço
            // 
            this.Preço.Text = "Preço";
            this.Preço.Width = 137;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProdutoLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewProdutoLoja);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inputPreco);
            this.Controls.Add(this.comboBoxLoja);
            this.Controls.Add(this.comboBoxProduto);
            this.Name = "ProdutoLoja";
            this.Text = "s";
            this.Load += new System.EventHandler(this.ProdutoLoja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.ComboBox comboBoxLoja;
        private System.Windows.Forms.TextBox inputPreco;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewProdutoLoja;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Loja;
        private System.Windows.Forms.ColumnHeader Preço;
        private System.Windows.Forms.Button button2;
    }
}