using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroCaixa : Form
    {
        public CadastroCaixa()
        {
            InitializeComponent();
        }

        private void buAdicionar_Click(object sender, EventArgs e)
        {
            int intQtdDeUsuario = -1;
            bool booVericacao = true;

            //estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblDescricaoCaixa", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                intQtdDeUsuario = Convert.ToInt32(linha["id_DescricaoCaixa"].ToString());

                if (Convert.ToString(linha["id_DescricaoCaixa"].ToString()) == textDescricao.Text)
                {
                    booVericacao = false;
                }
            }

            if (booVericacao != false)
            {
                intQtdDeUsuario = intQtdDeUsuario + 1;

                string query = "INSERT INTO tblDescricaoCaixa VALUES(" + intQtdDeUsuario + ",'" + Convert.ToString(textPeso.Text) + "','" + Convert.ToString(textDescricao.Text) + "')";

                SQLiteCommand comando = new SQLiteCommand(query, ligacao);
                comando.ExecuteNonQuery();

                comando.Dispose();
                ligacao.Dispose();

                // Carrega novamento os dados
                carregar();

                MessageBox.Show("Caixa cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("A descrição utilizada, já consta no sistema!");
            }
            textPeso.Text = "";
            textDescricao.Text = "";

        }

        private void CadastroCaixa_Load(object sender, EventArgs e)
        {
            carregar();
        }

        void carregar()
        {
            listViewDados.Items.Clear();

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
                var row = new string[] { linha["id_DescricaoCaixa"].ToString(), linha["peso"].ToString(), linha["varDescricao"].ToString() };
                var lvi = new ListViewItem(row);
                listViewDados.Items.Add(lvi);
            }
        }


    }
}
