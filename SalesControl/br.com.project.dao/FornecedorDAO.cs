using System;
using System.Collections.Generic;
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
    }
}
