using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LiberarUsuario : Form
    {
        public LiberarUsuario()
        {
            InitializeComponent();
        }

        private void LiberarUsuario_Load(object sender, EventArgs e)
        {
            IncluirValoresNaListView();
        }

        private void IncluirValoresNaListView()
        {
            listViewLiberados.Items.Clear();
            listViewBloqueados.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblUsuarios", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {
                var row = new string[] { linha["id_Usuario"].ToString(),
                                         linha["nameUser"].ToString()};

                var lvi = new ListViewItem(row);

                // Verifica se o usuario está bloqueado ou liberado
                if (Convert.ToBoolean(linha["booLiberado"].ToString()) == false)
                {
                    listViewBloqueados.Items.Add(lvi);
                }
                else
                {
                    listViewLiberados.Items.Add(lvi);
                }
            }
        }

        private void buttonBloquear_Click(object sender, EventArgs e)
        {
            AtualizarBancoDeDados(true, Convert.ToInt32(listViewLiberados.SelectedItems[0].SubItems[0].Text));
            IncluirValoresNaListView();

            MessageBox.Show("Usuario bloqueado com sucesso!");
        }

        private void buttonLiberar_Click(object sender, EventArgs e)
        {
            AtualizarBancoDeDados(true, Convert.ToInt32(listViewBloqueados.SelectedItems[0].SubItems[0].Text));
            IncluirValoresNaListView();

            MessageBox.Show("Usuario liberado com sucesso!");
        }

        private void AtualizarBancoDeDados(bool booValorUsuario, int intValorDoID)
        {
            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblUsuarios", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            string query = "update tblUsuarios set booLiberado=" + booValorUsuario + " where id_Usuario=" + intValorDoID;
            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();
        }

    }
}
