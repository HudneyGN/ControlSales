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
                executacmd.Parameters.AddWithValue(@"id", obj.codigo);
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

        #region Método alterar produto
        public void alterarProduto(Produto obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao=@descricao,preco=@preco,qtd_estoque=@qtd_estoque,for_id=@for_id
                                where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"descricao", obj.descricao);
                executacmd.Parameters.AddWithValue(@"preco", obj.preco);
                executacmd.Parameters.AddWithValue(@"qtd_estoque", obj.qtdestoque);
                executacmd.Parameters.AddWithValue(@"for_id", obj.codigoFornecedor);

                executacmd.Parameters.AddWithValue(@"id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dados do produto atualizado");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro! " + erro);
            }
        }
        #endregion

        #region método excluir Produto

        public void excluirPrduto(Produto obj)
        {
            try
            {
                string sql = "delete from tb_produtos where id = @id";
                //organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue(@"id", obj.codigo);

                //Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso! ");
                conexao.Close(); //fechando a conexao

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro! " + erro);
            }
        }
        #endregion

        #region Método listar ptodutos por nome com like
        public DataTable listarProdutoPorNome(string nome)
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
	                                   join tb_fornecedores as f on (p.for_id = f.id)
                                       where p.descricao like @nome;";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
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

        #region Método buscar produtos por nome

        public DataTable buscarProdutoPorNome(string nome)
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
	                                   join tb_fornecedores as f on (p.for_id = f.id)
                                       where p.descricao = @nome;";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
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

        #region Método que retorna produto por código

        public Produto retornaProdutoPorCodigo(int id)
        {
            try
            {
                // criar o comado sql

                string sql = @"select * from tb_produtos 
                                where id = @id";

                // organizar o comando sql 
                MySqlCommand executecmd = new MySqlCommand(sql, conexao);
                executecmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                // criar MysqldaraReader 
                MySqlDataReader rs = executecmd.ExecuteReader();
                if (rs.Read())
                {
                    Produto p = new Produto();
                    p.codigo = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");

                    conexao.Close();
                    return p;
                }
                else
                {
                    MessageBox.Show("Nenhum Produto encontrado com esse código");
                    conexao.Close();
                    return null;
                }

                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro! " + erro);
                conexao.Close();
                return null;
            }
        }
        #endregion
    }
}
