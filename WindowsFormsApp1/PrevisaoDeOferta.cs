using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PrevisaoDeOferta : Form
    {
        public PrevisaoDeOferta()
        {
            InitializeComponent();
        }

        private void PrevisaoDeOferta_Load(object sender, EventArgs e)
        {
            textBoxData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            IncluirValoresNaListView();
            IncluirTipoDeCaixa();
        }

        private void IncluirValoresNaListView()
        {
            listViewPrevisaoDeOferta.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblMovimentacaoPrevisao", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {


                // Verifica se o usuario está bloqueado ou liberado
                if (Convert.ToString(linha["dateData"].ToString()) == Convert.ToString(textBoxData.Text))
                {
                    var row = new string[] {
                                         linha["dateData"].ToString(),
                                         linha["intQuantidade"].ToString(),
                                         linha["varTipo"].ToString(),
                                         linha["varDescricao"].ToString()};

                    var lvi = new ListViewItem(row);

                    listViewPrevisaoDeOferta.Items.Add(lvi);
                }
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            int intQtdDeUsuario = 0;

            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblMovimentacaoPrevisao", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                intQtdDeUsuario = Convert.ToInt32(linha["id_Produto"].ToString());
            }

            intQtdDeUsuario = intQtdDeUsuario + 1;

            string query = "INSERT INTO tblMovimentacaoPrevisao VALUES(" + intQtdDeUsuario + "," +
                                                            "'" + Convert.ToString(textBoxData.Text) + "'," +
                                                                + Convert.ToInt32(textBoxQuantidade.Text) + "," +
                                                            "'" + Convert.ToString(comboBoxTipo.Text) + "')";

            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

            textBoxData.Text = "";
            textBoxQuantidade.Text = "";
            comboBoxTipo.Text = "";

            MessageBox.Show("Previsão de produto incluida com sucesso!");
        }

        private void IncluirTipoDeCaixa()
        {
            comboBoxTipo.Items.Clear();

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
                comboBoxTipo.Items.Add(linha["varDescricao"].ToString());
            }
        }
    }
}
