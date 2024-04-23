using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SalesControl.br.com.project.connection;
using SalesControl.br.com.project.model;

namespace SalesControl.br.com.project.dao
{
    // classe que contem os metodos sql
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                // definir o cmd sql - insert into
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";                // - organizar o comando
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"nome", obj.nome);
                executacmd.Parameters.AddWithValue(@"rg", obj.rg);
                executacmd.Parameters.AddWithValue(@"cpf", obj.cpf);
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

                // Abrir conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso! ");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cdastrar cliente: " + erro); 
            }
        }
        #endregion

    }
}
