using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LocalDeEstoque : Form
    {
        public LocalDeEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intQtdDeUsuario = 0;

            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblLocalDeEstoque", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                intQtdDeUsuario = Convert.ToInt32(linha["id_LocalDeEstoque"].ToString());
            }

            intQtdDeUsuario = intQtdDeUsuario + 1;

            string query = "INSERT INTO tblLocalDeEstoque VALUES(" + intQtdDeUsuario + ",'" + Convert.ToString(textLocal.Text) + "')";

            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

            textLocal.Text = "";

            IncluirValoresNaListView();

            MessageBox.Show("Local cadastrado com sucesso!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LocalDeEstoque_Load(object sender, EventArgs e)
        {
            IncluirValoresNaListView();
        }
        private void IncluirValoresNaListView()
        {
            listViewLocal.Items.Clear();

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
                var row = new string[] { linha["varNomeDoLocal"].ToString() };
                var lvi = new ListViewItem(row);

                listViewLocal.Items.Add(lvi);
            }
        }
    }
}
