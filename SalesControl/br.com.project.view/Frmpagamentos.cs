using Mysqlx;
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
    public partial class Frmpagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataAtual;

        public Frmpagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;

            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            //Carregar valores para tela 
            txttroco.Text = "0,00";
            txtdinheiro.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            // Botão finalizar venda
            try
{
                decimal v_dinheiro, v_cartao, troco, totalPago, total, faltaPagar;
                v_dinheiro = Convert.ToDecimal(txtdinheiro.Text);
                v_cartao = Convert.ToDecimal(txtcartao.Text);
                total = Convert.ToDecimal(txttotal.Text);

                //Calcular o total pago
                totalPago = v_dinheiro + v_cartao;

                if(totalPago < total)
                {
                    faltaPagar = total - totalPago;
                    MessageBox.Show("Restante a pagar: " + faltaPagar);
                }
                else
                {
                    //Calcular troco
                    troco = totalPago - total;

                    Venda vendas = new Venda();

                    vendas.cliente_id = cliente.codigo; //pegando o id do cliente
                    vendas.data_venda = dataAtual;
                    vendas.total_venda = total;
                    vendas.obs = txtobs.Text;

                    VendaDAO vdao = new VendaDAO();

                    txttroco.Text = troco.ToString();

                    vdao.cadastrarVenda(vendas);                  
                }
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro! " + erro);
            }

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdinheiro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
