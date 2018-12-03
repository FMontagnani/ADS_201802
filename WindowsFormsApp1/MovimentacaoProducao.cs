using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MovimentacaoProducao : Form
    {
        bool booValorUsuario;
        double intValorDoID = 0;

        public MovimentacaoProducao()
        {
            InitializeComponent();
        }

        private void MovimentacaoProducao_Load(object sender, EventArgs e)
        {

        }

        private void IncluirValoresNaListView()
        {
            listViewItens.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblMovimentacaoPedidos", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {


                // Verifica se o usuario está bloqueado ou liberado
                if (Convert.ToBoolean(linha["booStatusPedido"].ToString()) == false)
                {
                    var row = new string[] {
                                         linha["id_MovimentacaoPedidos"].ToString(),
                                         linha["varCliente"].ToString(),
                                         linha["dateData"].ToString(),
                                         linha["varDescricao"].ToString(),
                                         linha["varStatusDoPedido"].ToString(),
                                         linha["varTipoDeCaixa"].ToString(),
                                         linha["realPrecoDaCaixa"].ToString(),
                                         linha["intQuantidade"].ToString()};

                    var lvi = new ListViewItem(row);

                    listViewItens.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarBancoDeDados(true, Convert.ToInt32(listViewItens.SelectedItems[0].SubItems[0].Text));
            IncluirValoresNaListView();

            MessageBox.Show("Produção finalizado com sucesso!");
        }

        private void AtualizarBancoDeDados(bool booValorUsuario, int intValorDoID)
        {
            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblMovimentacaoPedidos", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            string query = "update tblMovimentacaoPedidos set booStatusPedido=" + booValorUsuario + " where id_MovimentacaoPedidos=" + intValorDoID;
            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();
        }
    }
}
