namespace WindowsFormsApp1
{
    partial class MovimentacaoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimentacaoEstoque));
            this.buMovimentar = new System.Windows.Forms.Button();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.textEstadoDoProduto = new System.Windows.Forms.TextBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDescricao = new System.Windows.Forms.ComboBox();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoDaCaixa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buMovimentar
            // 
            this.buMovimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buMovimentar.ForeColor = System.Drawing.Color.Black;
            this.buMovimentar.Location = new System.Drawing.Point(257, 310);
            this.buMovimentar.Margin = new System.Windows.Forms.Padding(2);
            this.buMovimentar.Name = "buMovimentar";
            this.buMovimentar.Size = new System.Drawing.Size(400, 37);
            this.buMovimentar.TabIndex = 106;
            this.buMovimentar.Text = "Movimentar";
            this.buMovimentar.UseVisualStyleBackColor = true;
            this.buMovimentar.Click += new System.EventHandler(this.buMovimentar_Click);
            // 
            // textComplemento
            // 
            this.textComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textComplemento.Location = new System.Drawing.Point(393, 255);
            this.textComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.textComplemento.MaxLength = 80;
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(265, 26);
            this.textComplemento.TabIndex = 104;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(272, 258);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 20);
            this.label20.TabIndex = 103;
            this.label20.Text = "Complemento";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textQuantidade.Location = new System.Drawing.Point(393, 218);
            this.textQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(265, 26);
            this.textQuantidade.TabIndex = 100;
            // 
            // textEstadoDoProduto
            // 
            this.textEstadoDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textEstadoDoProduto.Location = new System.Drawing.Point(393, 109);
            this.textEstadoDoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.textEstadoDoProduto.MaxLength = 30;
            this.textEstadoDoProduto.Name = "textEstadoDoProduto";
            this.textEstadoDoProduto.Size = new System.Drawing.Size(265, 26);
            this.textEstadoDoProduto.TabIndex = 97;
            // 
            // textData
            // 
            this.textData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textData.Location = new System.Drawing.Point(393, 41);
            this.textData.Margin = new System.Windows.Forms.Padding(2);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(265, 26);
            this.textData.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(289, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 94;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(338, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "Local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(274, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tipo de Caixa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(231, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Estado do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(302, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(342, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(9, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 314);
            this.panel1.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(78, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 87;
            this.label1.Text = "Estoque";
            // 
            // comboBoxDescricao
            // 
            this.comboBoxDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxDescricao.FormattingEnabled = true;
            this.comboBoxDescricao.Location = new System.Drawing.Point(393, 75);
            this.comboBoxDescricao.Name = "comboBoxDescricao";
            this.comboBoxDescricao.Size = new System.Drawing.Size(264, 28);
            this.comboBoxDescricao.TabIndex = 107;
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Location = new System.Drawing.Point(394, 181);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(264, 28);
            this.comboBoxLocal.TabIndex = 108;
            // 
            // comboBoxTipoDaCaixa
            // 
            this.comboBoxTipoDaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxTipoDaCaixa.FormattingEnabled = true;
            this.comboBoxTipoDaCaixa.Location = new System.Drawing.Point(394, 145);
            this.comboBoxTipoDaCaixa.Name = "comboBoxTipoDaCaixa";
            this.comboBoxTipoDaCaixa.Size = new System.Drawing.Size(264, 28);
            this.comboBoxTipoDaCaixa.TabIndex = 109;
            // 
            // MovimentacaoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(664, 358);
            this.Controls.Add(this.comboBoxTipoDaCaixa);
            this.Controls.Add(this.comboBoxLocal);
            this.Controls.Add(this.comboBoxDescricao);
            this.Controls.Add(this.buMovimentar);
            this.Controls.Add(this.textComplemento);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.textEstadoDoProduto);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovimentacaoEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.MovimentacaoEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buMovimentar;
        private System.Windows.Forms.TextBox textComplemento;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.TextBox textEstadoDoProduto;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.ComboBox comboBoxTipoDaCaixa;
    }
}