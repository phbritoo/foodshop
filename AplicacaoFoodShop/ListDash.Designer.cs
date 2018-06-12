namespace AplicacaoFoodShop
{
    partial class ListDash
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
            this.listViewDash = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewDash
            // 
            this.listViewDash.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Produto,
            this.Descrição,
            this.Loja,
            this.Preço});
            this.listViewDash.Location = new System.Drawing.Point(147, 98);
            this.listViewDash.Name = "listViewDash";
            this.listViewDash.Size = new System.Drawing.Size(480, 211);
            this.listViewDash.TabIndex = 0;
            this.listViewDash.UseCompatibleStateImageBehavior = false;
            this.listViewDash.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 96;
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 116;
            // 
            // Loja
            // 
            this.Loja.Text = "Loja";
            this.Loja.Width = 101;
            // 
            // Preço
            // 
            this.Preço.Text = "Preço";
            this.Preço.Width = 108;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewDash);
            this.Name = "ListDash";
            this.Text = "ListDash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDash;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader Loja;
        private System.Windows.Forms.ColumnHeader Preço;
        private System.Windows.Forms.Button button1;
    }
}