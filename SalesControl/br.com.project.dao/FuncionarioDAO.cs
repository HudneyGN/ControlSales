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
using System.Data;

namespace SalesControl.br.com.project.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;


        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }
        #region Cadastar Funcionário
        public void cadastrarFuncionario(Funcionario obj)
        {
            try
            {
                // criar o comando SQL

                string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) 
                                values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"nome", obj.nome);
                executacmd.Parameters.AddWithValue(@"rg", obj.rg);
                executacmd.Parameters.AddWithValue(@"cpf", obj.cpf);
                executacmd.Parameters.AddWithValue(@"email", obj.email);
                executacmd.Parameters.AddWithValue(@"senha", obj.senha);
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
            
        }
        #endregion

        #region Método ListarFuncionario
      
        public DataTable listarFuncionarios()
        {
            try
            {
                // Criar DataTAble e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);
                conexao.Close();
                return tabelafuncionario;

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
