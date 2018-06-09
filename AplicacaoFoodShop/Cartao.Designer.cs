namespace AplicacaoFoodShop
{
    partial class Cartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxBandeira = new System.Windows.Forms.TextBox();
            this.textBoxCodigoSeguranca = new System.Windows.Forms.TextBox();
            this.listViewCartao = new System.Windows.Forms.ListView();
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bandeira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CódigoSegurança = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bandeira :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Segurança :";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(416, 148);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(305, 38);
            this.textBoxNumero.TabIndex = 3;
            // 
            // textBoxBandeira
            // 
            this.textBoxBandeira.Location = new System.Drawing.Point(416, 203);
            this.textBoxBandeira.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxBandeira.Name = "textBoxBandeira";
            this.textBoxBandeira.Size = new System.Drawing.Size(305, 38);
            this.textBoxBandeira.TabIndex = 4;
            // 
            // textBoxCodigoSeguranca
            // 
            this.textBoxCodigoSeguranca.Location = new System.Drawing.Point(416, 258);
            this.textBoxCodigoSeguranca.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxCodigoSeguranca.Name = "textBoxCodigoSeguranca";
            this.textBoxCodigoSeguranca.Size = new System.Drawing.Size(305, 38);
            this.textBoxCodigoSeguranca.TabIndex = 5;
            // 
            // listViewCartao
            // 
            this.listViewCartao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Número,
            this.Bandeira,
            this.CódigoSegurança});
            this.listViewCartao.Location = new System.Drawing.Point(896, 60);
            this.listViewCartao.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listViewCartao.Name = "listViewCartao";
            this.listViewCartao.Size = new System.Drawing.Size(1156, 455);
            this.listViewCartao.TabIndex = 6;
            this.listViewCartao.UseCompatibleStateImageBehavior = false;
            this.listViewCartao.View = System.Windows.Forms.View.Details;
            this.listViewCartao.SelectedIndexChanged += new System.EventHandler(this.listViewCartao_SelectedIndexChanged);
            // 
            // Número
            // 
            this.Número.Text = "Numero";
            this.Número.Width = 133;
            // 
            // Bandeira
            // 
            this.Bandeira.Text = "Bandeira";
            this.Bandeira.Width = 118;
            // 
            // CódigoSegurança
            // 
            this.CódigoSegurança.Text = "CódigoSeguranca";
            this.CódigoSegurança.Width = 86;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(456, 358);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(200, 55);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(1392, 568);
            this.buttonListar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(200, 55);
            this.buttonListar.TabIndex = 8;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1803, 723);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.listViewCartao);
            this.Controls.Add(this.textBoxCodigoSeguranca);
            this.Controls.Add(this.textBoxBandeira);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Cartao";
            this.Text = "Cartao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxBandeira;
        private System.Windows.Forms.TextBox textBoxCodigoSeguranca;
        private System.Windows.Forms.ListView listViewCartao;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Bandeira;
        private System.Windows.Forms.ColumnHeader CódigoSegurança;
        private System.Windows.Forms.Button button1;
    }
}