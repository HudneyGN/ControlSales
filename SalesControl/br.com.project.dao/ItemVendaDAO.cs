using MySql.Data.MySqlClient;
using SalesControl.br.com.project.connection;
using SalesControl.br.com.project.model;
using System;
using System.Collections.Generic;
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
    }
}
