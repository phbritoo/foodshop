namespace AplicacaoFoodShop
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonLoja = new System.Windows.Forms.Button();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.buttonCartao = new System.Windows.Forms.Button();
            this.buttonCarrinho = new System.Windows.Forms.Button();
            this.buttonNotaFiscal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.Location = new System.Drawing.Point(220, 96);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(85, 77);
            this.buttonUsuario.TabIndex = 0;
            this.buttonUsuario.Text = "Usuário";
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonLoja
            // 
            this.buttonLoja.Location = new System.Drawing.Point(361, 96);
            this.buttonLoja.Name = "buttonLoja";
            this.buttonLoja.Size = new System.Drawing.Size(85, 77);
            this.buttonLoja.TabIndex = 1;
            this.buttonLoja.Text = "Loja";
            this.buttonLoja.UseVisualStyleBackColor = true;
            this.buttonLoja.Click += new System.EventHandler(this.buttonLoja_Click);
            // 
            // buttonProduto
            // 
            this.buttonProduto.Location = new System.Drawing.Point(493, 96);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(85, 77);
            this.buttonProduto.TabIndex = 2;
            this.buttonProduto.Text = "Produto";
            this.buttonProduto.UseVisualStyleBackColor = true;
            this.buttonProduto.Click += new System.EventHandler(this.buttonProduto_Click);
            // 
            // buttonCartao
            // 
            this.buttonCartao.Location = new System.Drawing.Point(220, 201);
            this.buttonCartao.Name = "buttonCartao";
            this.buttonCartao.Size = new System.Drawing.Size(85, 77);
            this.buttonCartao.TabIndex = 3;
            this.buttonCartao.Text = "Cartão";
            this.buttonCartao.UseVisualStyleBackColor = true;
            this.buttonCartao.Click += new System.EventHandler(this.buttonCartao_Click);
            // 
            // buttonCarrinho
            // 
            this.buttonCarrinho.Location = new System.Drawing.Point(361, 201);
            this.buttonCarrinho.Name = "buttonCarrinho";
            this.buttonCarrinho.Size = new System.Drawing.Size(85, 77);
            this.buttonCarrinho.TabIndex = 4;
            this.buttonCarrinho.Text = "Carrinho";
            this.buttonCarrinho.UseVisualStyleBackColor = true;
            this.buttonCarrinho.Click += new System.EventHandler(this.buttonCarrinho_Click);
            // 
            // buttonNotaFiscal
            // 
            this.buttonNotaFiscal.Location = new System.Drawing.Point(493, 201);
            this.buttonNotaFiscal.Name = "buttonNotaFiscal";
            this.buttonNotaFiscal.Size = new System.Drawing.Size(85, 77);
            this.buttonNotaFiscal.TabIndex = 5;
            this.buttonNotaFiscal.Text = "Nota Fiscal";
            this.buttonNotaFiscal.UseVisualStyleBackColor = true;
            this.buttonNotaFiscal.Click += new System.EventHandler(this.buttonNotaFiscal_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNotaFiscal);
            this.Controls.Add(this.buttonCarrinho);
            this.Controls.Add(this.buttonCartao);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.buttonLoja);
            this.Controls.Add(this.buttonUsuario);
            this.Name = "Principal";
            this.Text = "principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonLoja;
        private System.Windows.Forms.Button buttonProduto;
        private System.Windows.Forms.Button buttonCartao;
        private System.Windows.Forms.Button buttonCarrinho;
        private System.Windows.Forms.Button buttonNotaFiscal;
    }
}