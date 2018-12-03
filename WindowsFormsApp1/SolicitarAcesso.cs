using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SolicitarAcesso : Form
    {
        public SolicitarAcesso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intQtdDeUsuario = 0;
            bool booNomeUsuario = true;

            if (textUsuario.Text=="" || TextSenha.Text =="")
            {
                MessageBox.Show("Inclua ambas informações antes de continuar, o nome do usuario e a senha!");
            }
            else
            {
                ////estabelecer conecção com o banco de dados
                SQLiteConnection ligacao = new SQLiteConnection();
                ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
                ligacao.Open();

                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblUsuarios", ligacao);
                DataTable dados = new DataTable();
                adapter.Fill(dados);

                //Verifica os dados no banco
                foreach (DataRow linha in dados.Rows)
                {
                    // Verifica se o nome já existe na base de dados
                    intQtdDeUsuario = Convert.ToInt32(linha["id_Usuario"].ToString());
                    if (Convert.ToString(linha["nameUser"].ToString()) == Convert.ToString(textUsuario.Text))
                    {
                        booNomeUsuario = false;
                    }
                }

                if (booNomeUsuario != false)
                {
                    intQtdDeUsuario = intQtdDeUsuario + 1;

                    string query = "INSERT INTO tblUsuarios VALUES(" + intQtdDeUsuario + "," + "'" + textUsuario.Text + "'" + "," + "'" + TextSenha.Text + "'" + ",false)";

                    SQLiteCommand comando = new SQLiteCommand(query, ligacao);
                    comando.ExecuteNonQuery();

                    comando.Dispose();
                    ligacao.Dispose();

                    textUsuario.Text = "";
                    TextSenha.Text = "";

                    MessageBox.Show("Solicitação enviada com sucesso!");
                }
                else
                {
                    MessageBox.Show("O usuario " + textUsuario.Text + " já consta no banco de dados!");
                    textUsuario.Text = "";
                    TextSenha.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SolicitarAcesso_Load(object sender, EventArgs e)
        {

        }
    }
}
