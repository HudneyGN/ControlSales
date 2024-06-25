using MySql.Data.MySqlClient;
using SalesControl.br.com.project.connection;
using SalesControl.br.com.project.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesControl.br.com.project.dao
{
    public class ItemVendaDAO
    {
        private MySqlConnection conexao;

        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }
        #region Método que cadastra um item de venda
        public void cadastrarItem(ItemVenda obj)
        {
            try
            {
                // Criar o sql 
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                                values (@venda_id, @produto_id, @qtd, @subtotal)";

                // Organizar e executar o comando sql 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                //Abrir conexão
                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com sucesso!");
                conexao.Close(); //Fechar conexão

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro! " + erro);
            }
        }
        #endregion

        #region Método que lista todos os itens por venda
        public DataTable listarItensPorVenda(int venda_id)
        {
            try
            {
                // criar o DataTable e organizar o comando sql 
                DataTable tabelaItens = new DataTable();
                string sql = @"select i.id as 'Código',
		                              p.descricao as 'Descrição',
		                              i.qtd as 'Quantidade',
		                              p.preco as 'Preço',
		                              i.subtotal as 'Sub Total'
                            from tb_itensvendas as i
                            join tb_produtos as p 
                            on (i.produto_id = p.id)
                            where venda_id = @venda_id";

                //Organizar e executar o comando sql 
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@venda_id", venda_id);
                

                conexao.Open();
                executacmdsql.ExecuteNonQuery();


                // Criar o MySqladapter para preencher os dados no DataTable 
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaItens);
                conexao.Close();
                return tabelaItens;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
                conexao.Close();
                return null;
            }
        }

        #endregion
    }
}
