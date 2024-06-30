using MySqlX.XDevAPI.Common;
using SalesControl.br.com.project.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesControl.br.com.project.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir tela de cliente com a aba consulta aberto
            FrmClientes telaCliente = new FrmClientes();
            telaCliente.tabClientes.SelectedTab = telaCliente.tabPage2;
            telaCliente.ShowDialog();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir uma tela de cliente 
            FrmClientes telaCliente = new FrmClientes();
            
            telaCliente.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // abrir tela de funcionário
            FrmFuncionarios telaFuncionario = new FrmFuncionarios();
            telaFuncionario.ShowDialog();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // programando dentro do timer
            txthora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuCadastroFornecedores_Click(object sender, EventArgs e)
        {
            // Abrir uma tela de fornecedor 
            Frmfornecedores telaFornecedor = new Frmfornecedores();
            telaFornecedor.ShowDialog();
        }

        private void menuCadastroProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos telaProduto = new FrmProdutos();
            telaProduto.ShowDialog();
        }

        private void menuConsultaFuncionarios_Click(object sender, EventArgs e)
        {
            //Abrir tela de consulta de funcionários 
            FrmFuncionarios telaFuncionario = new FrmFuncionarios();
            telaFuncionario.tabFuncionario.SelectedTab = telaFuncionario.tabPage2;
            telaFuncionario.ShowDialog();
        }

        private void menuConsultaFornecedores_Click(object sender, EventArgs e)
        {
            //Abrir tela fornecedores aba de consulta 
            Frmfornecedores telaFornecedores = new Frmfornecedores();
            telaFornecedores.tabFornecedor.SelectedTab = telaFornecedores.tabPage2;
            telaFornecedores.ShowDialog();
        }

        private void tmenuConsultaProdutos_Click(object sender, EventArgs e)
        {
            //Abrir tela produtos na aba consultar produtos
            FrmProdutos telaProduto = new FrmProdutos();
            telaProduto.tabProduto.SelectedTab = telaProduto.tabPage2;
            telaProduto.ShowDialog();
        }

        private void menuVenda_Click(object sender, EventArgs e)
        {
           
        }

        private void menuNovaVenda_Click(object sender, EventArgs e)
        {
            Frmvendas telaVenda = new Frmvendas();
            telaVenda.ShowDialog();
        }

        private void menuHistoricoVenda_Click(object sender, EventArgs e)
        {
            Frmhistorico telaHistorico = new Frmhistorico();
            telaHistorico.ShowDialog();
        }

        private void menuSenha_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja alterar o usuário?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.Close();

                Frmlogin telaLogin = new Frmlogin();
                telaLogin.ShowDialog();
            } 
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            //Fechar a aplicação
            DialogResult result = MessageBox.Show("Deseja sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {

        }

        private void menuFuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void menuFornecedores_Click(object sender, EventArgs e)
        {

        }

        private void menuProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
