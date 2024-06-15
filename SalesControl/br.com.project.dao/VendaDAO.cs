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

                //MessageBox.Show("Venda efetuada com sucesso!");
                conexao.Close(); //Fechar conexão


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }

        #endregion

        #region Método que retorna o id da ultima venda 

        public int retornaIdUltimaVenda()
        {
            try
            {
                
                int idVenda = 0;

                // Criar o comando sql
                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao); 

                //Abrir conexão
                conexao.Open();

                MySqlDataReader rs = executacmdsql.ExecuteReader(); 

                //MessageBox.Show("Venda cadastrado com sucesso!");
                //conexao.Close(); //Fechar conexão

                if (rs.Read())
                {
                    idVenda = rs.GetInt32("id");
                    conexao.Close();                 
                }
                //rs.Close();
                conexao.Close();
                return idVenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro! " + erro);
                conexao.Close();
                return 0;
            }
            
        }

    }



    #endregion

}
