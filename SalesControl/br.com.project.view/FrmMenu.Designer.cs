namespace SalesControl.br.com.project.view
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menucadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenuConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuconfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionarios,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVenda,
            this.menuconfiguracoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroClientes,
            this.menuConsultaClientes});
            this.menuCliente.Image = global::SalesControl.Properties.Resources.clientesvs;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(109, 52);
            this.menuCliente.Text = "Clientes";
            // 
            // menuCadastroClientes
            // 
            this.menuCadastroClientes.Name = "menuCadastroClientes";
            this.menuCadastroClientes.Size = new System.Drawing.Size(182, 22);
            this.menuCadastroClientes.Text = "Cadastro de Clientes";
            this.menuCadastroClientes.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // menuConsultaClientes
            // 
            this.menuConsultaClientes.Name = "menuConsultaClientes";
            this.menuConsultaClientes.Size = new System.Drawing.Size(182, 22);
            this.menuConsultaClientes.Text = "Consulta de Clientes";
            this.menuConsultaClientes.Click += new System.EventHandler(this.consultaDeClientesToolStripMenuItem_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucadastroFuncionarios,
            this.menuConsultaFuncionarios});
            this.menuFuncionarios.Image = global::SalesControl.Properties.Resources.funcionariosvs;
            this.menuFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(135, 52);
            this.menuFuncionarios.Text = "Funcionários";
            // 
            // menucadastroFuncionarios
            // 
            this.menucadastroFuncionarios.Name = "menucadastroFuncionarios";
            this.menucadastroFuncionarios.Size = new System.Drawing.Size(208, 22);
            this.menucadastroFuncionarios.Text = "Cadastro de Funcionários";
            this.menucadastroFuncionarios.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuConsultaFuncionarios
            // 
            this.menuConsultaFuncionarios.Name = "menuConsultaFuncionarios";
            this.menuConsultaFuncionarios.Size = new System.Drawing.Size(208, 22);
            this.menuConsultaFuncionarios.Text = "Consulta de Funcionários";
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFornecedores,
            this.menuConsultaFornecedores});
            this.menuFornecedores.Image = global::SalesControl.Properties.Resources.fornecedoresvs;
            this.menuFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(138, 52);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // menuCadastroFornecedores
            // 
            this.menuCadastroFornecedores.Name = "menuCadastroFornecedores";
            this.menuCadastroFornecedores.Size = new System.Drawing.Size(211, 22);
            this.menuCadastroFornecedores.Text = "Cadastro de Fornecedores";
            // 
            // menuConsultaFornecedores
            // 
            this.menuConsultaFornecedores.Name = "menuConsultaFornecedores";
            this.menuConsultaFornecedores.Size = new System.Drawing.Size(211, 22);
            this.menuConsultaFornecedores.Text = "Consulta de Fornecedores";
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroProdutos,
            this.tmenuConsultaProdutos});
            this.menuProdutos.Image = global::SalesControl.Properties.Resources.produtos32;
            this.menuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(99, 52);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroProdutos
            // 
            this.menuCadastroProdutos.Name = "menuCadastroProdutos";
            this.menuCadastroProdutos.Size = new System.Drawing.Size(189, 22);
            this.menuCadastroProdutos.Text = "Cadastro de Produtoa";
            // 
            // tmenuConsultaProdutos
            // 
            this.tmenuConsultaProdutos.Name = "tmenuConsultaProdutos";
            this.tmenuConsultaProdutos.Size = new System.Drawing.Size(189, 22);
            this.tmenuConsultaProdutos.Text = "Consultar produtos";
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda,
            this.menuHistoricoVenda});
            this.menuVenda.Image = global::SalesControl.Properties.Resources.vendas32;
            this.menuVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(88, 52);
            this.menuVenda.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(180, 22);
            this.menuNovaVenda.Text = "Nova Venda";
            // 
            // menuHistoricoVenda
            // 
            this.menuHistoricoVenda.Name = "menuHistoricoVenda";
            this.menuHistoricoVenda.Size = new System.Drawing.Size(180, 22);
            this.menuHistoricoVenda.Text = "Histórico de vendas";
            // 
            // menuconfiguracoes
            // 
            this.menuconfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSenha,
            this.menuSair});
            this.menuconfiguracoes.Image = global::SalesControl.Properties.Resources.configuracoes32;
            this.menuconfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuconfiguracoes.Name = "menuconfiguracoes";
            this.menuconfiguracoes.Size = new System.Drawing.Size(128, 52);
            this.menuconfiguracoes.Text = "Configurações";
            this.menuconfiguracoes.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // menuSenha
            // 
            this.menuSenha.Name = "menuSenha";
            this.menuSenha.Size = new System.Drawing.Size(180, 22);
            this.menuSenha.Text = "Trocar Usuário";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(180, 22);
            this.menuSair.Text = "Sair";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(931, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "Data atual";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtdata
            // 
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(65, 17);
            this.txtdata.Text = "25/06/2024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel3.Text = "Hora atual";
            // 
            // txthora
            // 
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(34, 17);
            this.txthora.Text = "22:30";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel5.Text = "Usuário logado:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(50, 17);
            this.txtusuario.Text = "Hudney";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesControl.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal - Controle de vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menucadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProdutos;
        private System.Windows.Forms.ToolStripMenuItem tmenuConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
        private System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuHistoricoVenda;
        private System.Windows.Forms.ToolStripMenuItem menuconfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem menuSenha;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtdata;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txthora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel txtusuario;
    }
}