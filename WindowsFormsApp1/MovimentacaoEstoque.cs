using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MovimentacaoEstoque : Form
    {
        public MovimentacaoEstoque()
        {
            InitializeComponent();
        }

        private void buMovimentar_Click(object sender, EventArgs e)
        {
            int intQtdDeUsuario = 0;

            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblMovimentacaoEstoque", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                intQtdDeUsuario = Convert.ToInt32(linha["id_MovimentacaoEstoque"].ToString());
            }

            intQtdDeUsuario = intQtdDeUsuario + 1;

            string query = "INSERT INTO tblUsuarios VALUES(" + intQtdDeUsuario + "," +
                                                            "'" + Convert.ToString(textData.Text) + "'," +
                                                            "'" + Convert.ToString(comboBoxDescricao.Text) + "'," +
                                                            "'" + Convert.ToString(textEstadoDoProduto.Text) + "'," +
                                                            "'" + Convert.ToString(comboBoxTipoDaCaixa.Text) + "'," +
                                                            "'" + Convert.ToString(comboBoxLocal.Text) + "'," +
                                                            "'" + Convert.ToInt32(textQuantidade.Text) + "'," +
                                                            "'" + Convert.ToString(textComplemento.Text) + "')";


            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

            textData.Text = "";
            comboBoxDescricao.Text = "";
            textEstadoDoProduto.Text = "";
            comboBoxTipoDaCaixa.Text ="";
            comboBoxLocal.Text = "";
            textQuantidade.Text = "";
            textComplemento.Text = "";

            MessageBox.Show("Estoque inserido com sucesso!");
        }

        private void MovimentacaoEstoque_Load(object sender, EventArgs e)
        {
            textData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            IncluirDescricao();
            IncluirTipoDeCaixa();
            IncluirLocal();

        }
        private void IncluirDescricao()
        {
            comboBoxDescricao.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblProduto", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {
                comboBoxDescricao.Items.Add(linha["varDescricao"].ToString());
            }
        }

        private void IncluirTipoDeCaixa()
        {
            comboBoxTipoDaCaixa.Items.Clear();

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
                comboBoxTipoDaCaixa.Items.Add(linha["varDescricao"].ToString());
            }
        }

        private void IncluirLocal()
        {
            comboBoxLocal.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblLocalDeEstoque", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {
                comboBoxLocal.Items.Add(linha["varNomeDoLocal"].ToString());
            }
        }
    }
}
