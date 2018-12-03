namespace WindowsFormsApp1
{
    partial class CadastroCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCaixa));
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buAdicionar = new System.Windows.Forms.Button();
            this.listViewDados = new System.Windows.Forms.ListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textDescricao
            // 
            this.textDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textDescricao.Location = new System.Drawing.Point(364, 80);
            this.textDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.textDescricao.MaxLength = 80;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(265, 26);
            this.textDescricao.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(270, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descrição";
            // 
            // textPeso
            // 
            this.textPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textPeso.Location = new System.Drawing.Point(364, 43);
            this.textPeso.Margin = new System.Windows.Forms.Padding(2);
            this.textPeso.MaxLength = 15;
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(265, 26);
            this.textPeso.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(305, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(50, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cadastro de Caixa";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(8, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 243);
            this.panel1.TabIndex = 24;
            // 
            // buAdicionar
            // 
            this.buAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buAdicionar.Location = new System.Drawing.Point(281, 130);
            this.buAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buAdicionar.Name = "buAdicionar";
            this.buAdicionar.Size = new System.Drawing.Size(346, 37);
            this.buAdicionar.TabIndex = 32;
            this.buAdicionar.Text = "Adicionar";
            this.buAdicionar.UseVisualStyleBackColor = true;
            this.buAdicionar.Click += new System.EventHandler(this.buAdicionar_Click);
            // 
            // listViewDados
            // 
            this.listViewDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Peso,
            this.Descricao});
            this.listViewDados.Location = new System.Drawing.Point(281, 172);
            this.listViewDados.Name = "listViewDados";
            this.listViewDados.Size = new System.Drawing.Size(348, 112);
            this.listViewDados.TabIndex = 33;
            this.listViewDados.UseCompatibleStateImageBehavior = false;
            this.listViewDados.View = System.Windows.Forms.View.Details;
            // 
            // Numero
            // 
            this.Numero.Text = "Nº";
            this.Numero.Width = 30;
            // 
            // Peso
            // 
            this.Peso.Text = "Peso";
            this.Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Peso.Width = 100;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Descricao.Width = 200;
            // 
            // CadastroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(636, 289);
            this.Controls.Add(this.listViewDados);
            this.Controls.Add(this.buAdicionar);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroCaixa";
            this.Text = "Cadastro de Caixa";
            this.Load += new System.EventHandler(this.CadastroCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buAdicionar;
        private System.Windows.Forms.ListView listViewDados;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader Peso;
        private System.Windows.Forms.ColumnHeader Descricao;
    }
}