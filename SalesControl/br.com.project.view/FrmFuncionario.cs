using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesControl.br.com.project.dao;
using SalesControl.br.com.project.model;
using SalesControl.br.com.project.connection;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SalesControl.br.com.project.view
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtrg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtbairro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtrg_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void txtcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().Limpartela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //Botão salvar
            Funcionario obj = new Funcionario();

            //Receber os dados dos campos 
            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.nivelAcesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = Convert.ToInt32(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.cbuf = cbuf.Text;
            obj.cargo = cbcargo.SelectedItem.ToString();

            //Criar o objeto funcionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.cadastrarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão excluir
            Funcionario obj = new Funcionario();
            obj.codigo = Convert.ToInt32(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.deletarFuncionario(obj);

            // atualizar a tabela 
            tabelaFuncionario.DataSource = dao.listarFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //Editar 
            Funcionario obj = new Funcionario();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.cargo = cbcargo.Text;
            obj.nivelAcesso = cbnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = Convert.ToInt32(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.cbuf = cbuf.Text;

            obj.codigo = Convert.ToInt32(txtcodigo.Text);

            //Criar o objeto funcionarioDAO
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.alterarFuncionario(obj);

            tabelaFuncionario.DataSource = dao.listarFuncionarios();

        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionariosporNome(nome);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabelaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.listarFuncionarios();

        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = tabelaFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = tabelaFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = tabelaFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = tabelaFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = tabelaFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = tabelaFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbcargo.Text = tabelaFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbnivel.Text = tabelaFuncionario.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = tabelaFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = tabelaFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = tabelaFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = tabelaFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = tabelaFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = tabelaFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = tabelaFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = tabelaFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = tabelaFuncionario.CurrentRow.Cells[16].Value.ToString();


            tabFuncionario.SelectedTab = tabPage1;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //Botão pesquisar
            string nome = txtpesquisa.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFuncionario.DataSource = dao.BuscaFuncionariosPorNome(nome);

            // Carregando de novo caso não encontre funcionário pelo nome
            if(tabelaFuncionario.Rows.Count == 0 || tabelaFuncionario.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado! ");
                tabelaFuncionario.DataSource = dao.listarFuncionarios();
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

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
    }
}
