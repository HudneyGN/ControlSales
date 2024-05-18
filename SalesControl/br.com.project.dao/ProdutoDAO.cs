using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SalesControl.br.com.project.connection;
using System.Windows.Forms;
using SalesControl.br.com.project.model;
using Mysqlx;
using System.Data;

namespace SalesControl.br.com.project.dao
{
    public class ProdutoDAO
    {
        private MySqlConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método cadastrar produto
        public void cadastrarProduto(Produto obj)
        {
            try
            {
                // Criar o comando sql 
                string sql = @"insert into tb_produtos (descricao,preco,qtd_estoque,for_id)
                                values (@descricao,@preco,@qtd_estoque,@for_id)";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                //executacmd.Parameters.AddWithValue(@"id", obj.codigo);
                executacmd.Parameters.AddWithValue(@"descricao", obj.descricao);
                executacmd.Parameters.AddWithValue(@"preco", obj.preco);
                executacmd.Parameters.AddWithValue(@"qtd_estoque", obj.qtdestoque);
                executacmd.Parameters.AddWithValue(@"for_id", obj.codigoFornecedor);

                //Abrir conexão
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close(); //Fechar conexão


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao Cadastrar o produto: " + erro);
            }
        }
        #endregion

        #region Métodos que lista produtos

        public DataTable listarProduto()
        {
            try
            {
                // Criar DataTable e o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select  p.id as 'Código', 
		                               p.descricao as 'Descrição',
                                       p.preco as 'Preço',
                                       p.qtd_estoque as 'Estoque',
                                       f.nome as 'Fornecedor'
		                               from tb_produtos as p
	                                   join tb_fornecedores as f on (p.for_id = f.id);";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);
                conexao.Close(); //Fechar conexao
                return tabelaProduto;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
            
        }
        #endregion
    }
}
