using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MovimentacaoPedidos : Form
    {
        double dblQuantidadeUtilizada;
        double dblQuantidadeDisponivel;

        public MovimentacaoPedidos()
        {
            InitializeComponent();
        }

        private void MovimentacaoPedidos_Load(object sender, EventArgs e)
        {
            textBoxData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            IncluirRotinaCliente();
            IncluirDescricao();
            IncluirTipoDeCaixa();
        }

        private void IncluirRotinaCliente()
        {
            comboBoxCliente.Items.Clear();

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
                comboBoxCliente.Items.Add(linha["nameCliente"].ToString());
            }
        }

        private void IncluirDescricao()
        {
            comboBoxDescricaoDoProduto.Items.Clear();

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
                comboBoxDescricaoDoProduto.Items.Add(linha["varDescricao"].ToString());
            }
        }

        private void IncluirTipoDeCaixa()
        {
            comboBoxDescricaoDaCaixa.Items.Clear();

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
                comboBoxDescricaoDaCaixa.Items.Add(linha["varDescricao"].ToString());
            }
        }

        private void IncluirPedidoLista()
        {
            comboBoxDescricaoDaCaixa.Items.Clear();

            dblQuantidadeUtilizada = 0;
            dblQuantidadeDisponivel = 0;

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
                if (Convert.ToString(textBoxData.Text) == Convert.ToString(linha["dateData"].ToString()))
                {
                    var row = new string[] {
                                         linha["varCliente"].ToString(),
                                         linha["dateData"].ToString(),
                                         linha["varDescricao"].ToString(),
                                         linha["varStatusDoPedido"].ToString(),
                                         linha["varTipoDeCaixa"].ToString(),
                                         linha["realPrecoDaCaixa"].ToString(),
                                         linha["intQuantidade"].ToString(),
                                         linha["realDesconto"].ToString()};
                    var lvi = new ListViewItem(row);

                    comboBoxDescricaoDaCaixa.Items.Add(lvi);

                    dblQuantidadeUtilizada = dblQuantidadeUtilizada + Convert.ToDouble(linha["intQuantidade"].ToString());
                }
            }
            QuantidadeDisponivel();
        }

        private void QuantidadeDisponivel()
        {
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
                if (Convert.ToString(textBoxData.Text) == Convert.ToString(linha["dateData"].ToString()))
                {
                    if (comboBoxDescricaoDoProduto.Text == linha["varTipo"].ToString())
                    {
                        dblQuantidadeDisponivel = dblQuantidadeDisponivel + Convert.ToDouble(linha["intQuantidade"].ToString());
                    }
                }
            }

            labelQuantidade.Text =Convert.ToString(dblQuantidadeDisponivel - dblQuantidadeUtilizada);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(labelQuantidade.Text) - Convert.ToDouble(textBoxQuantidade.Text) >=0)
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
                    intQtdDeUsuario = Convert.ToInt32(linha["id_Previsao"].ToString());
                }

                intQtdDeUsuario = intQtdDeUsuario + 1;

                string query = "INSERT INTO tblMovimentacaoPrevisao VALUES(" 
                                                                    + intQtdDeUsuario + "," +
                                                                "'" + Convert.ToString(comboBoxCliente.Text) + "'," +
                                                                "'" + Convert.ToString(textBoxData.Text) + "'," +
                                                                "'" + Convert.ToString(comboBoxDescricaoDoProduto.Text) + "'," +
                                                                "'" + Convert.ToString(textBoxStatusDoProduto.Text) + "'," +
                                                                "'" + Convert.ToString(comboBoxDescricaoDaCaixa.Text) + "',"
                                                                    + Convert.ToDouble(textBoxPrecoDeCaixaTomate.Text) + ","
                                                                    + Convert.ToInt32(textBoxQuantidade.Text) + ","
                                                                    + Convert.ToDouble(textBoxDesconto.Text) + "," +
                                                                "'" + Convert.ToBoolean(comboBoxDescricaoDoProduto.Text) + "')";

                SQLiteCommand comando = new SQLiteCommand(query, ligacao);
                comando.ExecuteNonQuery();

                comando.Dispose();
                ligacao.Dispose();

                comboBoxCliente.Text = "";
                textBoxData.Text = "";
                comboBoxDescricaoDoProduto.Text = "";
                textBoxStatusDoProduto.Text = "";
                comboBoxDescricaoDaCaixa.Text = "";
                textBoxPrecoDeCaixaTomate.Text = "";
                textBoxQuantidade.Text = "";
                textBoxDesconto.Text = "";

                IncluirPedidoLista();

                MessageBox.Show("Pedido incluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Quantidade disponivel insuficinete para atender o pedido!");
            }
        }
    }
}
