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
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            tabelaHistorico.DataSource = dao.listarVendasPorPeriodo(datainicio, datafim);
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            //implementando o método listar venda

            VendaDAO dao = new VendaDAO();

            tabelaHistorico.DataSource = dao.listarVendas();
            tabelaHistorico.DefaultCellStyle.ForeColor = Color.Black; 
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abrir um outro formulário
            // passando o id da venda 
            int idvenda = Convert.ToInt32(tabelaHistorico.CurrentRow.Cells[0].Value.ToString()); // variável para pegar idvenda do dataGridView
            Frmdetalhe tela = new Frmdetalhe(idvenda); // instanciar obj para abrir formulário

            //Formatando a data
            DateTime dataVenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value);
            tela.txtdata.Text = dataVenda.ToString("dd-MM-yyyy");

            //tela.txtdata.Text = tabelaHistorico.CurrentRow.Cells[1].Value.ToString();
            tela.txtcliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txttotal.Text = tabelaHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtobs.Text = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();

            tela.ShowDialog(); // abrindo o formulário
        }
    }
}
