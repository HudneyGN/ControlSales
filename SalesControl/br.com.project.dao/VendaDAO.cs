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
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método Cadastrar venda 

        public void cadastrarVenda(Venda obj)
        {
            try
            {
                // Criar o sql 
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
                                values(@cliente_id, @data_venda, @total_venda, @observacoes)";

                // Organizar e executar o comando sql 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@observacoes", obj.obs);

                //Abrir conexão
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Venda cadastrado com sucesso!");
                conexao.Close(); //Fechar conexão


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }

        #endregion

    }
}
