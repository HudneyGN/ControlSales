
namespace SalesControl.br.com.project.view
{
    partial class FrmClientes
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaCliente = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::SalesControl.Properties.Resources.fundo;
            this.tabPage2.Controls.Add(this.tabelaCliente);
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.txtpesquisa);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(988, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabelaCliente
            // 
            this.tabelaCliente.AllowUserToAddRows = false;
            this.tabelaCliente.AllowUserToDeleteRows = false;
            this.tabelaCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaCliente.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabelaCliente.Location = new System.Drawing.Point(3, 130);
            this.tabelaCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabelaCliente.Name = "tabelaCliente";
            this.tabelaCliente.ReadOnly = true;
            this.tabelaCliente.Size = new System.Drawing.Size(744, 252);
            this.tabelaCliente.TabIndex = 49;
            this.tabelaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaCliente_CellClick);
            this.tabelaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaCliente_CellContentClick);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(534, 59);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(142, 30);
            this.btnpesquisar.TabIndex = 48;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(107, 59);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(396, 23);
            this.txtpesquisa.TabIndex = 47;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged_1);
            this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(28, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 46;
            this.label12.Text = "Nome:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::SalesControl.Properties.Resources.fundo;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.cbuf);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(988, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(2, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Complemento:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(119, 363);
            this.txtcomplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(377, 23);
            this.txtcomplemento.TabIndex = 54;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(382, 183);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(93, 28);
            this.btnbuscar.TabIndex = 53;
            this.btnbuscar.Text = "Pesquisar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(553, 318);
            this.cbuf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(59, 25);
            this.cbuf.TabIndex = 51;
            this.cbuf.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(9, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Bairro:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(6, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cidade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(521, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "UF:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(80, 222);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(310, 23);
            this.txtendereco.TabIndex = 47;
            this.txtendereco.TextChanged += new System.EventHandler(this.txtendereco_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(80, 54);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(387, 23);
            this.txtnome.TabIndex = 36;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(80, 94);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(387, 23);
            this.txtemail.TabIndex = 34;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(434, 228);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(62, 23);
            this.txtnumero.TabIndex = 32;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(76, 315);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(420, 23);
            this.txtcidade.TabIndex = 30;
            this.txtcidade.TextChanged += new System.EventHandler(this.txtcidade_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(81, 17);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(139, 23);
            this.txtcodigo.TabIndex = 25;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(2, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Endereço:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(80, 134);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelefone.Mask = "(##)####-####";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(116, 23);
            this.txttelefone.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(2, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Telefone:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(293, 185);
            this.txtcep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(83, 23);
            this.txtcep.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(249, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "CEP:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(80, 176);
            this.txtcelular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcelular.Mask = "(##)# ####-####";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(116, 23);
            this.txtcelular.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(3, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "Celular:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(531, 113);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(116, 23);
            this.txtcpf.TabIndex = 39;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(487, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "CPF:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(531, 67);
            this.txtrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtrg.Mask = "##.###.###-#";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(116, 23);
            this.txtrg.TabIndex = 37;
            this.txtrg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtrg_MaskInputRejected);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(7, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "Nome:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(6, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 33;
            this.label19.Text = "E-mail:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label20.Location = new System.Drawing.Point(487, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "RG:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label21.Location = new System.Drawing.Point(405, 228);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 17);
            this.label21.TabIndex = 29;
            this.label21.Text = "N°";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label22.Location = new System.Drawing.Point(-138, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 17);
            this.label22.TabIndex = 27;
            this.label22.Text = "Complemento:";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(76, 271);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(420, 23);
            this.txtbairro.TabIndex = 26;
            this.txtbairro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtbairro_MaskInputRejected);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label23.Location = new System.Drawing.Point(9, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 17);
            this.label23.TabIndex = 24;
            this.label23.Text = "Código:";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabPage1);
            this.tabClientes.Controls.Add(this.tabPage2);
            this.tabClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.Location = new System.Drawing.Point(0, 92);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(996, 482);
            this.tabClientes.TabIndex = 1;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(864, 608);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(110, 30);
            this.btneditar.TabIndex = 49;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(728, 608);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(110, 30);
            this.btnexcluir.TabIndex = 50;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(584, 608);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(110, 30);
            this.btnsalvar.TabIndex = 51;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(455, 608);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(110, 30);
            this.btnnovo.TabIndex = 52;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesControl.Properties.Resources.telalogin;
            this.ClientSize = new System.Drawing.Size(996, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.tabClientes);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCliente)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox txtbairro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DataGridView tabelaCliente;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcomplemento;
        public System.Windows.Forms.TabControl tabClientes;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
    }
}