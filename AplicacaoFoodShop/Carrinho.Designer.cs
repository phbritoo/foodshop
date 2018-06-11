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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho));
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUsuarioOk = new System.Windows.Forms.Button();
            this.comboBoxCartao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(196, 76);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione Usuário";
            // 
            // buttonUsuarioOk
            // 
            this.buttonUsuarioOk.Location = new System.Drawing.Point(333, 74);
            this.buttonUsuarioOk.Name = "buttonUsuarioOk";
            this.buttonUsuarioOk.Size = new System.Drawing.Size(50, 23);
            this.buttonUsuarioOk.TabIndex = 2;
            this.buttonUsuarioOk.Text = "Ok";
            this.buttonUsuarioOk.UseVisualStyleBackColor = true;
            this.buttonUsuarioOk.Click += new System.EventHandler(this.buttonUsuarioOk_Click);
            // 
            // comboBoxCartao
            // 
            this.comboBoxCartao.FormattingEnabled = true;
            this.comboBoxCartao.Location = new System.Drawing.Point(196, 112);
            this.comboBoxCartao.Name = "comboBoxCartao";
            this.comboBoxCartao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCartao.TabIndex = 3;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCartao);
            this.Controls.Add(this.buttonUsuarioOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUsuario);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUsuarioOk;
        private System.Windows.Forms.ComboBox comboBoxCartao;
    }
}