using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesControl.br.com.project.connection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SalesControl.br.com.project.model;
using Mysqlx;

namespace SalesControl.br.com.project.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO(MySqlConnection conexao)
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Cadastar Funcionário

        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                // criar o comando SQL
                string sql = "insert int tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)" +
                    "values (@nome,@rg,@cpf,@email,@senha,@nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                // organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"nome", obj.nome);
                executacmd.Parameters.AddWithValue(@"rg", obj.rg);
                executacmd.Parameters.AddWithValue(@"cpf", obj.cpf);
                executacmd.Parameters.AddWithValue(@"email", obj.email);
                executacmd.Parameters.AddWithValue(@"senga", obj.senha);
                executacmd.Parameters.AddWithValue(@"cargo", obj.cargo);
                executacmd.Parameters.AddWithValue(@"nivel_acesso", obj.nivelAcesso);
                executacmd.Parameters.AddWithValue(@"telefone", obj.telefone);
                executacmd.Parameters.AddWithValue(@"celular", obj.celular);
                executacmd.Parameters.AddWithValue(@"cep", obj.cep);
                executacmd.Parameters.AddWithValue(@"endereco", obj.endereco);
                executacmd.Parameters.AddWithValue(@"numero", obj.numero);
                executacmd.Parameters.AddWithValue(@"complemento", obj.complemento);
                executacmd.Parameters.AddWithValue(@"bairro", obj.bairro);
                executacmd.Parameters.AddWithValue(@"cidade", obj.cidade);
                executacmd.Parameters.AddWithValue(@"estado", obj.cbuf);

                //Abrir a conexão e executar o coamando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso! ");

                conexao.Close(); //Fechar a conexão

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro: " + erro);
            }
            finally
{
                MessageBox.Show("Ocorreu um erro na execução: ");
            }
        }
        #endregion
    }
}
