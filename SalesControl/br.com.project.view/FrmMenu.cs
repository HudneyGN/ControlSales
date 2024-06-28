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

        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abrir uma tela de cliente 
            FrmClientes telaCliente = new FrmClientes();
            telaCliente.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // abrir tela de funcionário
            FrmFuncionarios telafuncionario = new FrmFuncionarios();
            telafuncionario.Show();
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
            Frmfornecedores telafornecedor = new Frmfornecedores();
            telafornecedor.Show();
        }

        private void menuCadastroProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
