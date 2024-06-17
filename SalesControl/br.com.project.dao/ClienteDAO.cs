using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;
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
                                values (@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
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
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastrar cliente: " + erro);
            }

        }
        #endregion


        #region AlterarCliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                // definir o cmd sql - Update da tabela cliente
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,
                                celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
                                cidade=@cidade,estado=@estado
                                    where id=@id";

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

                executacmd.Parameters.AddWithValue(@"id", obj.codigo);


                // Abrir conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Atualizado com sucesso! ");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cdastrar cliente: " + erro);
            }
        }



        #endregion alterarCliente


        #region ExcluirCliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                // definir o cmd sql - insert into
                string sql = @"delete from tb_clientes where id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);


                executacmd.Parameters.AddWithValue(@"id", obj.codigo);


                // Abrir conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show(" Cliente excluído com sucesso! ");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cdastrar cliente: " + erro);
            }
        }

        #endregion ExcluirCliente


        #region ListarCliente
        public DataTable listarCliente()
        {
            try
            {
                // Criar DataTAble e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
                conexao.Close();
                return tabelacliente;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }


        #endregion listarCliente


        #region BuscarClientePorNome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                // Criar DataTAble e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes where nome like @nome";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);
                conexao.Close();
                return tabelacliente;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }

        #endregion

        #region método que retorna um cliente por cpf

        public Cliente retornaClienteporCpf(string cpf)
        {

            try
            {
                //Criar o Comando sql retornanso um cliente
                Cliente obj = new Cliente();

                string sql = @"select * from tb_clientes
                               where cpf=@cpf";

                // organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();
                MySqlDataReader rs = executacmd.ExecuteReader();

                //conexao.Close();

                if (rs.Read())
                {
                    obj.codigo = rs.GetInt32("id");
                    obj.nome = rs.GetString("nome");
                    conexao.Close();
                    return obj;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado! ");
                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Cliente não cadastrado no sistema! " + erro);
                conexao.Close();
                return null;
            }
        }
        #endregion

    }

}
    
