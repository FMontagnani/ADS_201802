namespace WindowsFormsApp1
{
    partial class CadastroDeProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeProduto));
            this.buAdicionar = new System.Windows.Forms.Button();
            this.textTamanho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textCodigoExterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewItens = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buAdicionar
            // 
            this.buAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buAdicionar.Location = new System.Drawing.Point(294, 170);
            this.buAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buAdicionar.Name = "buAdicionar";
            this.buAdicionar.Size = new System.Drawing.Size(346, 37);
            this.buAdicionar.TabIndex = 40;
            this.buAdicionar.Text = "Adicionar";
            this.buAdicionar.UseVisualStyleBackColor = true;
            this.buAdicionar.Click += new System.EventHandler(this.buAdicionar_Click);
            // 
            // textTamanho
            // 
            this.textTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textTamanho.Location = new System.Drawing.Point(386, 83);
            this.textTamanho.Margin = new System.Windows.Forms.Padding(2);
            this.textTamanho.MaxLength = 50;
            this.textTamanho.Name = "textTamanho";
            this.textTamanho.Size = new System.Drawing.Size(265, 26);
            this.textTamanho.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(301, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tamanho";
            // 
            // textDescricao
            // 
            this.textDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textDescricao.Location = new System.Drawing.Point(386, 46);
            this.textDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.textDescricao.MaxLength = 50;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(265, 26);
            this.textDescricao.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(295, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cadastro de Produto";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(2, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 166);
            this.panel1.TabIndex = 33;
            // 
            // textCodigoExterno
            // 
            this.textCodigoExterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textCodigoExterno.Location = new System.Drawing.Point(386, 122);
            this.textCodigoExterno.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigoExterno.MaxLength = 11;
            this.textCodigoExterno.Name = "textCodigoExterno";
            this.textCodigoExterno.Size = new System.Drawing.Size(265, 26);
            this.textCodigoExterno.TabIndex = 42;
            this.textCodigoExterno.TextChanged += new System.EventHandler(this.textCodigoExterno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Codigo Externo";
            // 
            // listViewItens
            // 
            this.listViewItens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewItens.Location = new System.Drawing.Point(2, 213);
            this.listViewItens.Name = "listViewItens";
            this.listViewItens.Size = new System.Drawing.Size(649, 115);
            this.listViewItens.TabIndex = 43;
            this.listViewItens.UseCompatibleStateImageBehavior = false;
            this.listViewItens.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descrição";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tamanho";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Codigo Externo";
            this.columnHeader3.Width = 100;
            // 
            // CadastroDeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(662, 331);
            this.Controls.Add(this.listViewItens);
            this.Controls.Add(this.textCodigoExterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buAdicionar);
            this.Controls.Add(this.textTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroDeProduto";
            this.Text = "Cadastro De Produto";
            this.Load += new System.EventHandler(this.CadastroDeProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buAdicionar;
        private System.Windows.Forms.TextBox textTamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textCodigoExterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewItens;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}