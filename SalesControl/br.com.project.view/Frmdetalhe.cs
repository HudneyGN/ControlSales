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
    public partial class Frmdetalhe : Form
    {
        int venda_id;
        public Frmdetalhe(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void Frmdetalhe_Load(object sender, EventArgs e)
        {
            //Carrega tela de detalhes
            ItemVendaDAO dao = new ItemVendaDAO();
            tabelaDetalhes.DataSource = dao.listarItensPorVenda(venda_id);
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
