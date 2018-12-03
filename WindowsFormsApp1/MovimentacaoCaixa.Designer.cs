namespace WindowsFormsApp1
{
    partial class MovimentacaoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimentacaoCaixa));
            this.label4 = new System.Windows.Forms.Label();
            this.buAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioFornecedor = new System.Windows.Forms.RadioButton();
            this.radioCliente = new System.Windows.Forms.RadioButton();
            this.textData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClienteFornecedor = new System.Windows.Forms.ComboBox();
            this.comboTipoDaCaixa = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(300, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Cliente / Fornecedor";
            // 
            // buAdicionar
            // 
            this.buAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buAdicionar.Location = new System.Drawing.Point(389, 229);
            this.buAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buAdicionar.Name = "buAdicionar";
            this.buAdicionar.Size = new System.Drawing.Size(346, 37);
            this.buAdicionar.TabIndex = 50;
            this.buAdicionar.Text = "Adicionar";
            this.buAdicionar.UseVisualStyleBackColor = true;
            this.buAdicionar.Click += new System.EventHandler(this.buAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo da Caixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Movimentação de Caixas";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 225);
            this.panel1.TabIndex = 43;
            // 
            // radioFornecedor
            // 
            this.radioFornecedor.AutoSize = true;
            this.radioFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioFornecedor.ForeColor = System.Drawing.Color.White;
            this.radioFornecedor.Location = new System.Drawing.Point(476, 79);
            this.radioFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.radioFornecedor.Name = "radioFornecedor";
            this.radioFornecedor.Size = new System.Drawing.Size(119, 24);
            this.radioFornecedor.TabIndex = 53;
            this.radioFornecedor.TabStop = true;
            this.radioFornecedor.Text = "Fornecedor";
            this.radioFornecedor.UseVisualStyleBackColor = true;
            this.radioFornecedor.CheckedChanged += new System.EventHandler(this.radioFornecedor_CheckedChanged);
            // 
            // radioCliente
            // 
            this.radioCliente.AutoSize = true;
            this.radioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioCliente.ForeColor = System.Drawing.Color.White;
            this.radioCliente.Location = new System.Drawing.Point(654, 79);
            this.radioCliente.Margin = new System.Windows.Forms.Padding(2);
            this.radioCliente.Name = "radioCliente";
            this.radioCliente.Size = new System.Drawing.Size(83, 24);
            this.radioCliente.TabIndex = 54;
            this.radioCliente.TabStop = true;
            this.radioCliente.Text = "Cliente";
            this.radioCliente.UseVisualStyleBackColor = true;
            this.radioCliente.CheckedChanged += new System.EventHandler(this.radioCliente_CheckedChanged);
            // 
            // textData
            // 
            this.textData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textData.Location = new System.Drawing.Point(473, 153);
            this.textData.Margin = new System.Windows.Forms.Padding(2);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(265, 26);
            this.textData.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(422, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Data";
            // 
            // textQuantidade
            // 
            this.textQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textQuantidade.Location = new System.Drawing.Point(474, 189);
            this.textQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.textQuantidade.Name = "textQuantidade";
            this.textQuantidade.Size = new System.Drawing.Size(265, 26);
            this.textQuantidade.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(369, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Quantidade";
            // 
            // comboClienteFornecedor
            // 
            this.comboClienteFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClienteFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboClienteFornecedor.FormattingEnabled = true;
            this.comboClienteFornecedor.Location = new System.Drawing.Point(474, 116);
            this.comboClienteFornecedor.Name = "comboClienteFornecedor";
            this.comboClienteFornecedor.Size = new System.Drawing.Size(264, 28);
            this.comboClienteFornecedor.TabIndex = 59;
            // 
            // comboTipoDaCaixa
            // 
            this.comboTipoDaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comboTipoDaCaixa.FormattingEnabled = true;
            this.comboTipoDaCaixa.Location = new System.Drawing.Point(474, 41);
            this.comboTipoDaCaixa.Name = "comboTipoDaCaixa";
            this.comboTipoDaCaixa.Size = new System.Drawing.Size(264, 28);
            this.comboTipoDaCaixa.TabIndex = 60;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(1, 272);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(737, 119);
            this.listView1.TabIndex = 61;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fornecedor/Cliente";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo da Caixa";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qunatidade";
            this.columnHeader5.Width = 100;
            // 
            // MovimentacaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(740, 392);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboTipoDaCaixa);
            this.Controls.Add(this.comboClienteFornecedor);
            this.Controls.Add(this.textQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioCliente);
            this.Controls.Add(this.radioFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buAdicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovimentacaoCaixa";
            this.Text = "Movimentação de Caixas";
            this.Load += new System.EventHandler(this.MovimentacaoCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioFornecedor;
        private System.Windows.Forms.RadioButton radioCliente;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboClienteFornecedor;
        private System.Windows.Forms.ComboBox comboTipoDaCaixa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}