using System;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroDeProduto : Form
    {
        public CadastroDeProduto()
        {
            InitializeComponent();
        }

        private void buAdicionar_Click(object sender, EventArgs e)
        {
            int intQtdDeUsuario = 0;

            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblProduto", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                intQtdDeUsuario = Convert.ToInt32(linha["id_Produto"].ToString());
            }

            intQtdDeUsuario = intQtdDeUsuario + 1;

            string query = "INSERT INTO tblProduto VALUES(" + intQtdDeUsuario + "," +
                                                            "'" + Convert.ToString(textDescricao.Text) + "'" + "," +
                                                            "'" + Convert.ToString(textTamanho.Text) + "'" + "," +
                                                            "'" + Convert.ToString(textCodigoExterno.Text) + "'" + ")";

            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

            textDescricao.Text = "";
            textTamanho.Text = "";
            textCodigoExterno.Text = "";

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void CadastroDeProduto_Load(object sender, EventArgs e)
        {
            IncluirValoresNaListView();
        }

        private void IncluirValoresNaListView()
        {
            listViewItens.Items.Clear();

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
                var row = new string[] { linha["varDescricao"].ToString(),
                                         linha["varTamanho"].ToString(),
                                         linha["varCodigoExterno"].ToString()};

                var lvi = new ListViewItem(row);
                listViewItens.Items.Add(lvi);
            }
        }

        private void textCodigoExterno_TextChanged(object sender, EventArgs e)
        {
            textCodigoExterno.Text = Regex.Replace(textCodigoExterno.Text, "[^0-9]", "");
        }
    }
}
