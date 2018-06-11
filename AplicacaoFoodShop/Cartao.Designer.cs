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
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bandeira :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Segurança :";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(156, 62);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(133, 20);
            this.textBoxNumero.TabIndex = 3;
            // 
            // textBoxBandeira
            // 
            this.textBoxBandeira.Location = new System.Drawing.Point(156, 85);
            this.textBoxBandeira.Name = "textBoxBandeira";
            this.textBoxBandeira.Size = new System.Drawing.Size(133, 20);
            this.textBoxBandeira.TabIndex = 4;
            // 
            // textBoxCodigoSeguranca
            // 
            this.textBoxCodigoSeguranca.Location = new System.Drawing.Point(156, 108);
            this.textBoxCodigoSeguranca.Name = "textBoxCodigoSeguranca";
            this.textBoxCodigoSeguranca.Size = new System.Drawing.Size(133, 20);
            this.textBoxCodigoSeguranca.TabIndex = 5;
            // 
            // listViewCartao
            // 
            this.listViewCartao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Número,
            this.Bandeira,
            this.CódigoSegurança,
            this.Nome});
            this.listViewCartao.Location = new System.Drawing.Point(336, 25);
            this.listViewCartao.Name = "listViewCartao";
            this.listViewCartao.Size = new System.Drawing.Size(550, 193);
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
            this.CódigoSegurança.Width = 103;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(170, 183);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(597, 236);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 8;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(156, 134);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(133, 21);
            this.comboBoxUsuario.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuário :";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 154;
            // 
            // Cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 601);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxUsuario);
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
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Nome;
    }
}