using SalesControl.br.com.project.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesControl.br.com.project.view
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnentrar_Click(object sender, EventArgs e)
        {
            //Botão entrar da tela de login
            string nome = txtemail.Text;
            string email = txtemail.Text;
            string senha = txtsenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if(dao.efetuaLogin(email,senha,nome))
            {
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
