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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesControl.br.com.project.view
{
    public partial class Frmvendas : Form
    {
        // instanciando objeto de Cliente
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        // instanciando objeto de Produto
        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        //declaração de variáveis
        int qtd;
        decimal preco, subtotal, total;

        //carrinho
        DataTable carrinho = new DataTable(); // objeto da classe DataTable 



        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaprodutos.DataSource = carrinho;

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            //Botão adicionar item
            qtd = Convert.ToInt32(txtqtd.Text);
            preco = Convert.ToDecimal(txtpreco.Text);

            subtotal = qtd * preco;

            total = total + subtotal;

            //adicionar item no carrinho
            carrinho.Rows.Add(Convert.ToInt32(txtcodigo.Tag), txtdescricao.Text, qtd, preco, subtotal);

            txttotal.Text = total.ToString();

            //limpar campos 
            txtcodigo.Clear();
            txtdescricao.Clear();
            txtqtd.Clear();
            txtpreco.Clear();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            //Botão remover item 
            decimal subproduto = Convert.ToDecimal(tabelaprodutos.CurrentRow.Cells[4].Value.ToString());

            int indice = tabelaprodutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;

            txttotal.Text = total.ToString();

            MessageBox.Show("Item removido com sucesso!");
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.retornaClienteporCpf(txtcpf.Text);

                txtnome.Text = cliente.nome;
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                p = pdao.retornaProdutoPorodigo(Convert.ToInt32(txtcodigo.Text));

                txtdescricao.Text = p.descricao;
                txtpreco.Text = p.preco.ToString();
            }
        }
    }
}
