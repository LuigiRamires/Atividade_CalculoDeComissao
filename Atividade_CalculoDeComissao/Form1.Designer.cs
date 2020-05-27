namespace Atividade_CalculoDeComissao
{
    partial class frmComissao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbVendedor = new System.Windows.Forms.GroupBox();
            this.rdbCategoriaA = new System.Windows.Forms.RadioButton();
            this.rdbCategoriaB = new System.Windows.Forms.RadioButton();
            this.rdbCategoriaC = new System.Windows.Forms.RadioButton();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorComissao = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblValorComissao = new System.Windows.Forms.Label();
            this.btnCalcularComissao = new System.Windows.Forms.Button();
            this.gpbVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbVendedor
            // 
            this.gpbVendedor.Controls.Add(this.rdbCategoriaC);
            this.gpbVendedor.Controls.Add(this.rdbCategoriaB);
            this.gpbVendedor.Controls.Add(this.rdbCategoriaA);
            this.gpbVendedor.Location = new System.Drawing.Point(24, 22);
            this.gpbVendedor.Name = "gpbVendedor";
            this.gpbVendedor.Size = new System.Drawing.Size(170, 144);
            this.gpbVendedor.TabIndex = 0;
            this.gpbVendedor.TabStop = false;
            this.gpbVendedor.Text = "Categoria do Vendedor:";
            // 
            // rdbCategoriaA
            // 
            this.rdbCategoriaA.AutoSize = true;
            this.rdbCategoriaA.Location = new System.Drawing.Point(23, 36);
            this.rdbCategoriaA.Name = "rdbCategoriaA";
            this.rdbCategoriaA.Size = new System.Drawing.Size(80, 17);
            this.rdbCategoriaA.TabIndex = 0;
            this.rdbCategoriaA.TabStop = true;
            this.rdbCategoriaA.Text = "Categoria A";
            this.rdbCategoriaA.UseVisualStyleBackColor = true;
            // 
            // rdbCategoriaB
            // 
            this.rdbCategoriaB.AutoSize = true;
            this.rdbCategoriaB.Location = new System.Drawing.Point(23, 74);
            this.rdbCategoriaB.Name = "rdbCategoriaB";
            this.rdbCategoriaB.Size = new System.Drawing.Size(80, 17);
            this.rdbCategoriaB.TabIndex = 1;
            this.rdbCategoriaB.TabStop = true;
            this.rdbCategoriaB.Text = "Categoria B";
            this.rdbCategoriaB.UseVisualStyleBackColor = true;
            // 
            // rdbCategoriaC
            // 
            this.rdbCategoriaC.AutoSize = true;
            this.rdbCategoriaC.Location = new System.Drawing.Point(23, 112);
            this.rdbCategoriaC.Name = "rdbCategoriaC";
            this.rdbCategoriaC.Size = new System.Drawing.Size(80, 17);
            this.rdbCategoriaC.TabIndex = 2;
            this.rdbCategoriaC.TabStop = true;
            this.rdbCategoriaC.Text = "Categoria C";
            this.rdbCategoriaC.UseVisualStyleBackColor = true;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(269, 44);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 1;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorVenda_KeyPress);
            // 
            // txtValorComissao
            // 
            this.txtValorComissao.Enabled = false;
            this.txtValorComissao.Location = new System.Drawing.Point(269, 137);
            this.txtValorComissao.Name = "txtValorComissao";
            this.txtValorComissao.Size = new System.Drawing.Size(100, 20);
            this.txtValorComissao.TabIndex = 2;
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(257, 27);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(122, 13);
            this.lblValorVenda.TabIndex = 3;
            this.lblValorVenda.Text = "Digite o Valor da Venda:";
            // 
            // lblValorComissao
            // 
            this.lblValorComissao.AutoSize = true;
            this.lblValorComissao.Location = new System.Drawing.Point(272, 121);
            this.lblValorComissao.Name = "lblValorComissao";
            this.lblValorComissao.Size = new System.Drawing.Size(97, 13);
            this.lblValorComissao.TabIndex = 4;
            this.lblValorComissao.Text = "Valor da Comissão:";
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.Location = new System.Drawing.Point(260, 77);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(115, 31);
            this.btnCalcularComissao.TabIndex = 5;
            this.btnCalcularComissao.Text = "Calcular Comissão";
            this.btnCalcularComissao.UseVisualStyleBackColor = true;
            this.btnCalcularComissao.Click += new System.EventHandler(this.BtnCalcularComissao_Click);
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 185);
            this.Controls.Add(this.btnCalcularComissao);
            this.Controls.Add(this.lblValorComissao);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.txtValorComissao);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.gpbVendedor);
            this.Name = "frmComissao";
            this.Tag = "";
            this.Text = "Comissões";
            this.gpbVendedor.ResumeLayout(false);
            this.gpbVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbVendedor;
        private System.Windows.Forms.RadioButton rdbCategoriaC;
        private System.Windows.Forms.RadioButton rdbCategoriaB;
        private System.Windows.Forms.RadioButton rdbCategoriaA;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorComissao;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblValorComissao;
        private System.Windows.Forms.Button btnCalcularComissao;
    }
}

