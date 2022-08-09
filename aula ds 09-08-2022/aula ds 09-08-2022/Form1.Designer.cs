namespace aula_ds_09_08_2022
{
    partial class Form1
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
            this.gboxproduto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.txtResltadoNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResltadoEstoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResltadoValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResltadoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResltadoDesconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gboxproduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxproduto
            // 
            this.gboxproduto.BackgroundImage = global::aula_ds_09_08_2022.Properties.Resources.estoque;
            this.gboxproduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gboxproduto.Controls.Add(this.txtResltadoDesconto);
            this.gboxproduto.Controls.Add(this.label8);
            this.gboxproduto.Controls.Add(this.txtResltadoTotal);
            this.gboxproduto.Controls.Add(this.label4);
            this.gboxproduto.Controls.Add(this.txtResltadoValor);
            this.gboxproduto.Controls.Add(this.label7);
            this.gboxproduto.Controls.Add(this.txtResltadoEstoque);
            this.gboxproduto.Controls.Add(this.label6);
            this.gboxproduto.Controls.Add(this.txtResltadoNome);
            this.gboxproduto.Controls.Add(this.label5);
            this.gboxproduto.Controls.Add(this.btncalc);
            this.gboxproduto.Controls.Add(this.txtValor);
            this.gboxproduto.Controls.Add(this.label3);
            this.gboxproduto.Controls.Add(this.txtQuant);
            this.gboxproduto.Controls.Add(this.label2);
            this.gboxproduto.Controls.Add(this.txtNome);
            this.gboxproduto.Controls.Add(this.label1);
            this.gboxproduto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxproduto.Location = new System.Drawing.Point(62, 30);
            this.gboxproduto.Name = "gboxproduto";
            this.gboxproduto.Size = new System.Drawing.Size(806, 401);
            this.gboxproduto.TabIndex = 0;
            this.gboxproduto.TabStop = false;
            this.gboxproduto.Text = "tabela do estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 25);
            this.txtNome.TabIndex = 1;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(27, 202);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 25);
            this.txtQuant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "estoque";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(27, 147);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 25);
            this.txtValor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "valor unitario";
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(27, 242);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(90, 37);
            this.btncalc.TabIndex = 6;
            this.btncalc.Text = "calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            // 
            // txtResltadoNome
            // 
            this.txtResltadoNome.Enabled = false;
            this.txtResltadoNome.Location = new System.Drawing.Point(521, 62);
            this.txtResltadoNome.Name = "txtResltadoNome";
            this.txtResltadoNome.Size = new System.Drawing.Size(100, 25);
            this.txtResltadoNome.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "estoque";
            // 
            // txtResltadoEstoque
            // 
            this.txtResltadoEstoque.Enabled = false;
            this.txtResltadoEstoque.Location = new System.Drawing.Point(521, 103);
            this.txtResltadoEstoque.Name = "txtResltadoEstoque";
            this.txtResltadoEstoque.Size = new System.Drawing.Size(100, 25);
            this.txtResltadoEstoque.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "nome";
            // 
            // txtResltadoValor
            // 
            this.txtResltadoValor.Enabled = false;
            this.txtResltadoValor.Location = new System.Drawing.Point(521, 150);
            this.txtResltadoValor.Name = "txtResltadoValor";
            this.txtResltadoValor.Size = new System.Drawing.Size(100, 25);
            this.txtResltadoValor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "valor unitario";
            // 
            // txtResltadoTotal
            // 
            this.txtResltadoTotal.Enabled = false;
            this.txtResltadoTotal.Location = new System.Drawing.Point(521, 202);
            this.txtResltadoTotal.Name = "txtResltadoTotal";
            this.txtResltadoTotal.Size = new System.Drawing.Size(100, 25);
            this.txtResltadoTotal.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "valor total";
            // 
            // txtResltadoDesconto
            // 
            this.txtResltadoDesconto.Enabled = false;
            this.txtResltadoDesconto.Location = new System.Drawing.Point(521, 248);
            this.txtResltadoDesconto.Name = "txtResltadoDesconto";
            this.txtResltadoDesconto.Size = new System.Drawing.Size(100, 25);
            this.txtResltadoDesconto.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "desconto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1151, 472);
            this.Controls.Add(this.gboxproduto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxproduto.ResumeLayout(false);
            this.gboxproduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxproduto;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResltadoDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResltadoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResltadoValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResltadoEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResltadoNome;
        private System.Windows.Forms.Label label5;
    }
}

