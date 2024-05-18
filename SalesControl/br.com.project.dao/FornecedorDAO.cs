using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SalesControl.br.com.project.connection;
using SalesControl.br.com.project.model;
using SalesControl.br.com.project.view;

namespace SalesControl.br.com.project.dao
{
    public class FornecedorDAO
    {
        private MySqlConnection conexao;
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método para cadastrar fornecedor
        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                //1 definir o cmd sql - insert into para tabela fornecedores do MySql
                string sql = @"insert into tb_fornecedores (nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome,@cnpj,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2 Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"nome", obj.nome);
                executacmd.Parameters.AddWithValue(@"cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue(@"email", obj.email);
                executacmd.Parameters.AddWithValue(@"telefone", obj.telefone);
                executacmd.Parameters.AddWithValue(@"celular", obj.celular);
                executacmd.Parameters.AddWithValue(@"cep", obj.cep);
                executacmd.Parameters.AddWithValue(@"endereco", obj.endereco);
                executacmd.Parameters.AddWithValue(@"numero", obj.numero);
                executacmd.Parameters.AddWithValue(@"complemento", obj.complemento);
                executacmd.Parameters.AddWithValue(@"bairro", obj.bairro);
                executacmd.Parameters.AddWithValue(@"cidade", obj.cidade);
                executacmd.Parameters.AddWithValue(@"estado", obj.cbuf);

                //abrir conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com Sucesso! ");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrat funcionário! " + erro);
            }
        }

        #endregion

        #region Métodos que lista fornecedores

        public DataTable listarFornecedores()
        {
            try
            {
                // Criar DataTable e o comando sql
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);
                conexao.Close(); //Fechar conexao
                return tabelafornecedor;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
        #endregion

        #region Métodos que lista todos fornecedores por nome

        public DataTable listarFornecedorPorNome(string nome)
        {
            try
            {
                // Criar DataTable e o comando sql
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome like @nome";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);
                conexao.Close(); //Fechar conexao
                return tabelafornecedor;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
        #endregion

        #region Métodos que busca um fornecedores por nome

        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                // Criar DataTable e o comando sql
                DataTable tabelafornecedor = new DataTable();
                string sql = "select * from tb_fornecedores where nome = @nome";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafornecedor);
                conexao.Close(); //Fechar conexao
                return tabelafornecedor;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
        #endregion


        #region metodo para alterar fornecedor
        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                // crir comando slq update
                string sql = @"update tb_fornecedores set nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,
                                numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                                    where id = @id";
                //Organizar e executar o comando sql 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"nome", obj.nome);
                executacmd.Parameters.AddWithValue(@"cnpj", obj.cnpj);              
                executacmd.Parameters.AddWithValue(@"email", obj.email);                                   
                executacmd.Parameters.AddWithValue(@"telefone", obj.telefone);
                executacmd.Parameters.AddWithValue(@"celular", obj.celular);
                executacmd.Parameters.AddWithValue(@"cep", obj.cep);
                executacmd.Parameters.AddWithValue(@"endereco", obj.endereco);
                executacmd.Parameters.AddWithValue(@"numero", obj.numero);
                executacmd.Parameters.AddWithValue(@"complemento", obj.complemento);
                executacmd.Parameters.AddWithValue(@"bairro", obj.bairro);
                executacmd.Parameters.AddWithValue(@"cidade", obj.cidade);
                executacmd.Parameters.AddWithValue(@"estado", obj.cbuf);

                executacmd.Parameters.AddWithValue(@"id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dados do fornecedor atualizado");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar dados do fornecedor" + erro);
                
            }
        }
        #endregion

        #region método excluir fornecedor

        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = "delete from tb_fornecedores where id = @id";
                //organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue(@"id", obj.codigo);

                //Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso! ");
                conexao.Close(); //fechando a conexao

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro! " + erro);
            }
        }
        #endregion
    }
}
