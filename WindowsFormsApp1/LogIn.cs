using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        private SQLiteConnection ligacao;
        string strCaminho;

        public LogIn()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Boolean booAcesso;

            booAcesso = false;

            ////estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblUsuarios", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                if (linha["nameUser"].ToString() == UserName.Text)
                {
                    if (linha["pswUser"].ToString() == textSenha.Text)
                    {
                        booAcesso = true;
                        this.Hide();
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.ShowDialog();
                    }
                }
            }

            if (booAcesso == false)
            {
                MessageBox.Show("Usuario ou senha incorreta!");
            }



            //////criar a base de dados
            //SQLiteConnection.CreateFile(@"C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db");

            ////estabelecer conecção com o banco de dados
            //SQLiteConnection ligacao = new SQLiteConnection();
            //ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            //ligacao.Open();


            ////Criar uma tabela na base de dados
            //string query = "CREATE TABLE tblUsuarios(" +
            //                "id_Usuario             int," +
            //                "nameUser               varchar(30)," +
            //                "pswUser                varchar(30)," +
            //                "booLiberado            boolean)";
            //SQLiteCommand command = new SQLiteCommand(query, ligacao);
            //command.ExecuteNonQuery();

            ////Cliente
            //string query2 = "CREATE TABLE tblClientes(" +
            //                "id_Clientes             int," +
            //                "nameCliente             varchar(50)," +
            //                "nameFantasia            varchar(50)," +
            //                "charCPF_CNPJ            varchar(11)," +
            //                "charInscricaoEstadual   varchar(11)," +
            //                "charCodigoExterno       varchar(11)," +
            //                "realValorDoFrete        real," +
            //                "realDescontoPadrao      real," +
            //                "varNomeDaRua            varchar(80)," +
            //                "intNumeroDaRua          int," +
            //                "varComplemento          varchar(80)," +
            //                "varBairro               varchar(80)," +
            //                "varUF                   varchar(2)," +
            //                "varCidade               varchar(80)," +
            //                "varCEP                  varchar(8)," +
            //                "varEmail                varchar(80)," +
            //                "varFone                 varchar(15)," +
            //                "varCelular              varchar(15)," +
            //                "varCargo                varchar(50)," +
            //                "varNome                 varchar(80))";

            //SQLiteCommand command2 = new SQLiteCommand(query2, ligacao);
            //command2.ExecuteNonQuery();

            ////Fornecedor
            //string query4 = "CREATE TABLE tblFornecedor(" +
            //                "id_Fornecedor             int," +
            //                "nameFornecedor            varchar(50)," +
            //                "nameFantasia              varchar(50)," +
            //                "charCPF_CNPJ              varchar(11)," +
            //                "charInscricaoEstadual     varchar(11)," +
            //                "charCodigoExterno         varchar(11)," +
            //                "varNomeDaRua              varchar(80)," +
            //                "intNumeroDaRua            int," +
            //                "varComplemento            varchar(80)," +
            //                "varBairro                 varchar(80)," +
            //                "varUF                     varchar(2)," +
            //                "varCidade                 varchar(80)," +
            //                "varCEP                    varchar(8)," +
            //                "varEmail                  varchar(80)," +
            //                "varFone                   varchar(15)," +
            //                "varCelular                varchar(15)," +
            //                "varCargo                  varchar(50)," +
            //                "varNome                   varchar(80))";

            //SQLiteCommand command4 = new SQLiteCommand(query4, ligacao);
            //command4.ExecuteNonQuery();

            ////Produto
            //string query5 = "CREATE TABLE tblProduto(" +
            //                "id_Produto             int," +
            //                "varDescricao           varchar(50)," +
            //                "varTamanho             varchar(50)," +
            //                "varCodigoExterno       varchar(11))";

            //SQLiteCommand command6 = new SQLiteCommand(query5, ligacao);
            //command6.ExecuteNonQuery();

            ////Estoque
            //string query40 = "CREATE TABLE tblLocalDeEstoque(" +
            //                "id_LocalDeEstoque      int," +
            //                "varNomeDoLocal         varchar(50))";

            //SQLiteCommand command7 = new SQLiteCommand(query40, ligacao);
            //command7.ExecuteNonQuery();


            ////MovimentacaoCaixa
            //string query6 = "CREATE TABLE tblMovimentacaoCaixa(" +
            //                "id_MovimentacaoCaixa             int," +
            //                "varTipoCaixa                     varchar(80)," +
            //                "varTipoDeMovimentacao            varchar(20)," +
            //                "varClienteFornecedor             varchar(80)," +
            //                "varData                          varchar(11)," +
            //                "intQuantidade                    int)";

            //SQLiteCommand command8 = new SQLiteCommand(query6, ligacao);
            //command8.ExecuteNonQuery();

            ////MovimentacaoEstoque
            //string query7 = "CREATE TABLE tblMovimentacaoEstoque(" +
            //                "id_MovimentacaoEstoque        int," +
            //                "dateData                      varchar(11)," +
            //                "varDescricao                  varchar(80)," +
            //                "varEstadoDoProduto            varchar(30)," +
            //                "varTipoDeCaixa                varchar(80)," +
            //                "varLocal                      varchar(80)," +
            //                "intQuantidade                 int," +
            //                "varComplemento                varchar(80))";

            //SQLiteCommand command9 = new SQLiteCommand(query7, ligacao);
            //command9.ExecuteNonQuery();

            ////MovimentacaoPedidos
            //string query8 = "CREATE TABLE tblMovimentacaoPedidos(" +
            //                "id_MovimentacaoPedidos        int," +
            //                "varCliente                    varchar(50)," +
            //                "dateData                      varchar(11)," +
            //                "varDescricao                  varchar(80)," +
            //                "varStatusDoPedido             varchar(80)," +
            //                "varTipoDeCaixa                varchar(80)," +
            //                "realPrecoDaCaixa              real," +
            //                "intQuantidade                 int," +
            //                "realDesconto                  real," +
            //                "booStatusPedido               boolean)";

            //SQLiteCommand command10 = new SQLiteCommand(query8, ligacao);
            //command10.ExecuteNonQuery();

            ////Previsao
            //string query10 = "CREATE TABLE tblMovimentacaoPrevisao(" +
            //                "id_Previsao            int," +
            //                "dateData               varchar(11)," +
            //                "intQuantidade          int," +
            //                "varTipo                varchar(80))";

            //SQLiteCommand command12 = new SQLiteCommand(query10, ligacao);
            //command12.ExecuteNonQuery();

            ////Previsao
            //string query11 = "CREATE TABLE tblDescricaoCaixa(" +
            //                "id_DescricaoCaixa      int," +
            //                "peso                   varchar(15)," +
            //                "varDescricao           varchar(80))";

            //SQLiteCommand command13 = new SQLiteCommand(query11, ligacao);
            //command13.ExecuteNonQuery();

            //////Inserir dados no banco
            ////SQLiteConnection ligacao = new SQLiteConnection();
            ////ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ////ligacao.Open;

            ////string query = "INSERT INTO contactos VALUES(0,'João Ribeiro','12313213213')";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolicitarAcesso SolicitarCadastroNovoUser = new SolicitarAcesso();
            SolicitarCadastroNovoUser.ShowDialog();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
