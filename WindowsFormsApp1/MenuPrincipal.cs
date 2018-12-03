using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente CadastroDeCliente = new CadastroCliente();
            CadastroDeCliente.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeFornecedor CadastroParaFornecedor = new CadastroDeFornecedor();
            CadastroParaFornecedor.ShowDialog();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CadastroCaixa CadastroParaCaixa = new CadastroCaixa();
            CadastroParaCaixa.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CadastroDeProduto CadastroParaProduto = new CadastroDeProduto();
            CadastroParaProduto.ShowDialog();
        }

        private void localDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LocalDeEstoque CadastroParaEstoque = new LocalDeEstoque();
            CadastroParaEstoque.ShowDialog();
        }

        private void previsãoDeOfertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrevisaoDeOferta PrevisaoParaOferta = new PrevisaoDeOferta();
            PrevisaoParaOferta.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimentacaoPedidos MovimentacaoParaPedidos = new MovimentacaoPedidos();
            MovimentacaoParaPedidos.ShowDialog();
        }

        private void produçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimentacaoProducao MovimentacaoParaProducao = new MovimentacaoProducao();
            MovimentacaoParaProducao.ShowDialog();
        }

        private void caixasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MovimentacaoCaixa MovimentacaoParaCaixa = new MovimentacaoCaixa();
            MovimentacaoParaCaixa.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovimentacaoEstoque MovimentacaoParaEstoque = new MovimentacaoEstoque();
            MovimentacaoParaEstoque.ShowDialog();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarRelatorio Relatorio = new CriarRelatorio();
            Relatorio.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LiberarUsuario LiberarUsuario = new LiberarUsuario();
            LiberarUsuario.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
