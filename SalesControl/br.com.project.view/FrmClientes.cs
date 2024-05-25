using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesControl.br.com.project.model;
using SalesControl.br.com.project.dao;

namespace SalesControl.br.com.project.view
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // armazenar os dados em um objeto model

            Cliente obj = new Cliente();

            //obj.codigo = Convert.ToInt32(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = Convert.ToInt32(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.cbuf = cbuf.Text;

            // criar objeto clienteDAO
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //recarregar o datagridview
            tabelaCliente.DataSource = dao.listarCliente();

            new Helpers().Limpartela(this);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            tabelaCliente.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.listarCliente();
        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpesquisar_Click(object sende, EventArgs e)
        {
            // Botão pesquisar
            string nome = txtpesquisa.Text;
            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            if(tabelaCliente.Rows.Count == 0)
            {
                tabelaCliente.DataSource = dao.listarCliente();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtbairro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar os dados da linha selecionada 
            txtcodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            //Alterar para a guia Dados pessoais
            tabClientes.SelectedTab = tabPage1;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão excluir
            Cliente obj = new Cliente();

            //pegar o código
            obj.codigo = Convert.ToInt32(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();

            dao.excluirCliente(obj);

            //Recarregar o datagridview
            tabelaCliente.DataSource = dao.listarCliente();

            new Helpers().Limpartela(this);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            //obj.codigo = Convert.ToInt32(txtcodigo.Text);
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = Convert.ToInt32(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.cbuf = cbuf.Text;

            // criar objeto clienteDAO e chamar o metodo alterar
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //Recarregar o datagridview
            tabelaCliente.DataSource = dao.listarCliente();

            new Helpers().Limpartela(this);
        }

        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //Botão consultar CEP
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
               
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");
            }
        }

        private void txtcidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().Limpartela(this);
        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtpesquisa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
