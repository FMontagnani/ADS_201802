using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MovimentacaoCaixa : Form
    {
        public MovimentacaoCaixa()
        {
            InitializeComponent();
        }

        private void buAdicionar_Click(object sender, EventArgs e)
        {
            int intQtdDeUsuario = 0;
            string strTipoDeMovimentacao;

            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblMovimentacaoCaixa", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                intQtdDeUsuario = Convert.ToInt32(linha["id_MovimentacaoCaixa"].ToString());
            }

            intQtdDeUsuario = intQtdDeUsuario + 1;

            if (radioFornecedor.Checked == true)
            {
                strTipoDeMovimentacao = "Fornecedor";
            }
            else
            {
                strTipoDeMovimentacao = "Cliente";
            }

            string query = "INSERT INTO tblUsuarios VALUES(" + intQtdDeUsuario + "," +
                                                            "'" + Convert.ToString(comboTipoDaCaixa.Text) + "'," +
                                                            "'" + Convert.ToString(strTipoDeMovimentacao) + "'," +
                                                            "'" + Convert.ToString(comboClienteFornecedor.Text) + "'," +
                                                            "'" + Convert.ToString(textData.Text) + "'," +
                                                                  Convert.ToInt32(textQuantidade.Text) + ")";


            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

            comboTipoDaCaixa.Text = "";

            radioFornecedor.Checked = false;
            radioCliente.Checked = false;

            comboClienteFornecedor.Text = "";
            textData.Text = "";
            textQuantidade.Text = "";

            MessageBox.Show("Caixas movimentadas com sucesso!");
        }

        private void MovimentacaoCaixa_Load(object sender, EventArgs e)
        {
            textData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            IncluirValoresTipoCaixa();
        }

        private void IncluirValoresTipoCaixa()
        {
            comboTipoDaCaixa.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblDescricaoCaixa", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {
                comboTipoDaCaixa.Items.Add(linha["varDescricao"].ToString());
            }
        }

        private void radioFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            comboClienteFornecedor.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblFornecedor", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {
                comboClienteFornecedor.Items.Add(linha["nameFornecedor"].ToString());
            }
        }

        private void radioCliente_CheckedChanged(object sender, EventArgs e)
        {
            comboClienteFornecedor.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblClientes", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {
                comboClienteFornecedor.Items.Add(linha["nameCliente"].ToString());
            }
        }
    }
}
