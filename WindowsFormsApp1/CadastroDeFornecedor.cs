using System;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroDeFornecedor : Form
    {
        public CadastroDeFornecedor()
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

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblFornecedor", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //apresentar dados
            foreach (DataRow linha in dados.Rows)
            {
                intQtdDeUsuario = Convert.ToInt32(linha["id_Fornecedor"].ToString());
            }

            intQtdDeUsuario = intQtdDeUsuario + 1;

            string query = "INSERT INTO tblFornecedor VALUES(" + intQtdDeUsuario + "," + 
                                                           "'" + Convert.ToString(textRazaoSocial.Text) + "'," + 
                                                           "'" + Convert.ToString(textNomeFantazia.Text) + "'," +
                                                           "'" + Convert.ToString(textCPF_CNPJ.Text) + "'," +
                                                           "'" + Convert.ToString(textIncricaoEstadual.Text) + "'," +
                                                           "'" + Convert.ToString(textCodigoExterno.Text) + "'," +
                                                           "'" + Convert.ToString(textNomeDaRua.Text) + "'," +
                                                               + Convert.ToInt32(textNumero.Text) + "," +
                                                           "'" + Convert.ToString(textComplemento.Text) + "'," +
                                                           "'" + Convert.ToString(textBairro.Text) + "'," +
                                                           "'" + Convert.ToString(comboBoxUF.Text) + "'," +
                                                           "'" + Convert.ToString(textCidade.Text) + "'," +
                                                           "'" + Convert.ToString(textCEP.Text) + "'," +
                                                           "'" + Convert.ToString(textEmail.Text) + "'," +
                                                           "'" + Convert.ToString(textFone.Text) + "'," +
                                                           "'" + Convert.ToString(textCelular.Text) + "'," +
                                                           "'" + Convert.ToString(textCargo.Text) + "'," +
                                                           "'" + Convert.ToString(textNome.Text) + "')";

            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

            textRazaoSocial.Text = "";
            textNomeFantazia.Text = "";
            textCPF_CNPJ.Text = "";
            textIncricaoEstadual.Text = "";
            textCodigoExterno.Text = "";
            textNomeDaRua.Text = "";
            textNumero.Text = "";
            textComplemento.Text = "";
            textBairro.Text = "";
            comboBoxUF.Text = "";
            textCidade.Text = "";
            textCEP.Text = "";
            textEmail.Text = "";
            textFone.Text = "";
            textCelular.Text = "";
            textCargo.Text = "";
            textNome.Text = "";

            MessageBox.Show("Solicitação enviada com sucesso!");
        }

        private void CadastroDeFornecedor_Load(object sender, EventArgs e)
        {
            EstadosBrasileiros();
            IncluirValoresNaListView();
        }

        private void IncluirValoresNaListView()
        {
            listViewItens.Items.Clear();

            //Estabelecer conecção com o banco de dados
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\psben\OneDrive\Documentos\Visual Studio\csharp\WindowsFormsApp1\dados.db; Version=3";
            ligacao.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM tblFornecedor", ligacao);
            DataTable dados = new DataTable();
            adapter.Fill(dados);

            //Adiciona os dados em lista
            foreach (DataRow linha in dados.Rows)
            {
                var row = new string[] { linha["id_Fornecedor"].ToString(),
                                         linha["nameFornecedor"].ToString(),
                                         linha["nameFantasia"].ToString(),
                                         linha["charCPF_CNPJ"].ToString(),
                                         linha["charInscricaoEstadual"].ToString(),
                                         linha["charCodigoExterno"].ToString(),
                                         linha["varNomeDaRua"].ToString(),
                                         linha["intNumeroDaRua"].ToString(),
                                         linha["varComplemento"].ToString(),
                                         linha["varBairro"].ToString(),
                                         linha["varUF"].ToString(),
                                         linha["varCidade"].ToString(),
                                         linha["varCEP"].ToString(),
                                         linha["varEmail"].ToString(),
                                         linha["varFone"].ToString(),
                                         linha["varCelular"].ToString(),
                                         linha["varCargo"].ToString(),
                                         linha["varNome"].ToString() };
            var lvi = new ListViewItem(row);
                listViewItens.Items.Add(lvi);
            }
        }

        private void EstadosBrasileiros()
        {
            // Adiciona as siglas dos estados brasileiros
            comboBoxUF.Items.Clear();

            comboBoxUF.Items.Add("SP");
            comboBoxUF.Items.Add("MG");
            comboBoxUF.Items.Add("AC");
            comboBoxUF.Items.Add("AL");
            comboBoxUF.Items.Add("AP");
            comboBoxUF.Items.Add("AM");
            comboBoxUF.Items.Add("BA");
            comboBoxUF.Items.Add("CE");
            comboBoxUF.Items.Add("DF");
            comboBoxUF.Items.Add("ES");
            comboBoxUF.Items.Add("GO");
            comboBoxUF.Items.Add("MA");
            comboBoxUF.Items.Add("MT");
            comboBoxUF.Items.Add("MS");
            comboBoxUF.Items.Add("PA");
            comboBoxUF.Items.Add("PB");
            comboBoxUF.Items.Add("PR");
            comboBoxUF.Items.Add("PE");
            comboBoxUF.Items.Add("PI");
            comboBoxUF.Items.Add("RJ");
            comboBoxUF.Items.Add("RN");
            comboBoxUF.Items.Add("RS");
            comboBoxUF.Items.Add("RO");
            comboBoxUF.Items.Add("RR");
            comboBoxUF.Items.Add("SC");
            comboBoxUF.Items.Add("SE");
            comboBoxUF.Items.Add("TO");
        }

        private void textCPF_CNPJ_TextChanged(object sender, EventArgs e)
        {
            textCPF_CNPJ.Text = Regex.Replace(textCPF_CNPJ.Text, "[^0-9]", "");
        }

        private void textCodigoExterno_TextChanged(object sender, EventArgs e)
        {
            textCodigoExterno.Text = Regex.Replace(textCodigoExterno.Text, "[^0-9]", "");
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {
            textNumero.Text = Regex.Replace(textNumero.Text, "[^0-9]", "");
        }

        private void textCEP_TextChanged(object sender, EventArgs e)
        {
            textCEP.Text = Regex.Replace(textCEP.Text, "[^0-9]-", "");
        }

        private void textFone_TextChanged(object sender, EventArgs e)
        {
            textFone.Text = Regex.Replace(textFone.Text, "[^0-9-]", "");
        }

        private void textCelular_TextChanged(object sender, EventArgs e)
        {
            textCelular.Text = Regex.Replace(textCelular.Text, "[^0-9-]", "");
        }

    }
}
