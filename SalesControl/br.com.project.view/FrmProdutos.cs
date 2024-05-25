using System;
using System.Globalization;
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

namespace SalesControl.br.com.project.view
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            //Botão novo
            new Helpers().Limpartela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            // Botão salvar
            Produto obj = new Produto(); // Criando objeto da classe produto
            obj.descricao = txtdescricao.Text;
            obj.preco = Convert.ToDecimal(txtpreco.Text);
            obj.qtdestoque = Convert.ToInt32(txtqtd.Text);
            obj.codigoFornecedor = Convert.ToInt32(cbfornecedor.SelectedValue.ToString());

            //Criando objeto da classe ProdutoDAO
            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastrarProduto(obj);

            //Carregar o datagriview de produto
            tabelaProduto.DataSource = dao.listarProduto();

            new Helpers().Limpartela(this);

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão excluir
            Produto obj = new Produto();
            obj.codigo = Convert.ToInt32(txtcodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirPrduto(obj);

            // atualizar a tabela 
            tabelaProduto.DataSource = dao.listarProduto();

            new Helpers().Limpartela(this);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //Botão Editar Produto

            Produto obj = new Produto();
            obj.descricao = txtdescricao.Text;
            obj.preco = Convert.ToDecimal(txtpreco.Text);
            obj.qtdestoque = Convert.ToInt32(txtqtd.Text);
            obj.codigoFornecedor = Convert.ToInt32(cbfornecedor.SelectedValue.ToString()); //tinha um erro

            obj.codigo = Convert.ToInt32(txtcodigo.Text);

            //Criar o objeto funcionarioDAO
            ProdutoDAO dao = new ProdutoDAO();

            dao.alterarProduto(obj); 
            
            new Helpers().Limpartela(this);

            tabelaProduto.DataSource = dao.listarProduto();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbfornecedor.DataSource = f_dao.listarFornecedores();
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProduto.DataSource = dao.listarProduto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código do fornecedor: " + cbfornecedor.SelectedValue);
        }

        private void texpreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabelaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cria evento quando clica em uma linha selecionada datagridview adicionar na outra aba
            txtcodigo.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = tabelaProduto.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = tabelaProduto.CurrentRow.Cells[2].Value.ToString();
            txtqtd.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();

            //Alterar para a guia dados 
            tabProduto.SelectedTab = tabPage1;
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtpesquisa.Text + "%"; //% para pesquiser tudo qe vier antes e depois do resultado 

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProduto.DataSource = dao.listarProdutoPorNome(nome);

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProduto.DataSource = dao.buscarProdutoPorNome(nome);
            
            if (tabelaProduto.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto encontrado");
                tabelaProduto.DataSource = dao.listarProduto();
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
