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
using SalesControl.br.com.project.view;

namespace SalesControl.br.com.project.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;


        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }
        #region método Cadastar Funcionário
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

        #region método alterar funcionário
        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,
                                telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado 
                                where id = @id"; 
                   
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

                executacmd.Parameters.AddWithValue(@"id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Dados do funcionário atualizado");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro! " + erro);
            }
        }

        #endregion

        #region método excluir funcionário

        public void deletarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where id = @id";
                //organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                
                executacmd.Parameters.AddWithValue(@"id", obj.codigo);

                //Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com sucesso! ");
                conexao.Close(); //fechando a conexao

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro! " + erro);
            }
        }
        #endregion

        #region Método ListarFuncionario
        public DataTable listarFuncionarios()
        {
            try
            {
                // Criar DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);
                conexao.Close(); //Fechar conexao
                return tabelafuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
        #endregion

        #region método BuscaFuncionariosPorNome
        public DataTable BuscaFuncionariosPorNome(string nome) // pesquisa exata e não por aproximação
        {
            try
            {
                // Criar DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome = @nome";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);
                conexao.Close(); //Fechar conexao
                return tabelafuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
        #endregion

        #region Método que lista funcionário por nome

        public DataTable listarFuncionariosporNome(string nome)
        {
            try
            {
                // Criar DataTable e o comando sql
                DataTable tabelafuncionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome like @nome";

                // Organizar o comando sql e executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // criar o MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelafuncionario);
                conexao.Close(); //Fechar conexao
                return tabelafuncionario;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
        #endregion

        #region Método que efetua login

        public bool efetuaLogin(string email, string senha, string nome)
        {
            try
            {
                // criar o comando sql 
                string sql = @"select * from tb_funcionarios
                                        where nome = @nome
                                        or email = @email
                                        and senha = @senha";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue(@"nome", nome);
                executacmd.Parameters.AddWithValue(@"email", email);
                executacmd.Parameters.AddWithValue(@"senha", senha);

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();

                if (reader.Read())
                {
                    //MessageBox.Show("Login realizado com sucesso!");

                    //Nível de acesso no sistema
                    string nivel = reader.GetString("nivel_acesso");
                    //string nomeDeAcesso = reader.GetString("nome");
                    MessageBox.Show("Bem vindo " + reader.GetString("nome"));

                    //abrir menu principal
                    FrmMenu telamenu = new FrmMenu();

                    //Verificar nível de acesso
                    if (nivel.Equals("Administrador"))
                    {
                        telamenu.Show();
                    }
                    else if (nivel.Equals("Usuario"))
                    {
                        telamenu.menuProdutos.Enabled = false;
                        telamenu.menuCadastroClientes.Enabled = false;
                        telamenu.menucadastroFuncionarios.Enabled = false;
                        telamenu.menuCadastroFornecedores.Enabled = false;
                        telamenu.menuCadastroProdutos.Enabled = false;

                        telamenu.Show();
                    }
                    return true;
                }
                else
                {
                    // deu alguma coisa errada
                    MessageBox.Show("Login ou Senha incorreta! ");
                    return false;
                }               
            }
            catch (Exception erro )
            {
                
                MessageBox.Show("Ocorreu um erro na execução! " + erro);
                return false;
            }
        }
        #endregion
    }
}
