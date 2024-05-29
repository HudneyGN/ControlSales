using SalesControl.br.com.project.dao;
using SalesControl.br.com.project.model;
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
    public partial class Frmvendas : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        public Frmvendas()
        {
            InitializeComponent();
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {

        }

        private void grupoBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.retornaClienteporCpf(txtcpf.Text);

                txtnome.Text = cliente.nome;
            }
        }
    }
}
