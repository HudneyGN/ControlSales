
namespace SalesControl.br.com.project.view
{
    partial class FrmProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProduto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelaProduto = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabProduto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 86);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastro de Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.tabPage1);
            this.tabProduto.Controls.Add(this.tabPage2);
            this.tabProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProduto.Location = new System.Drawing.Point(12, 94);
            this.tabProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.SelectedIndex = 0;
            this.tabProduto.Size = new System.Drawing.Size(527, 399);
            this.tabProduto.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtpreco);
            this.tabPage1.Controls.Add(this.cbfornecedor);
            this.tabPage1.Controls.Add(this.txtqtd);
            this.tabPage1.Controls.Add(this.txtdescricao);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(519, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Produtos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(100, 102);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(96, 23);
            this.txtpreco.TabIndex = 50;
            this.txtpreco.TextChanged += new System.EventHandler(this.texpreco_TextChanged);
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(103, 182);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(314, 25);
            this.cbfornecedor.TabIndex = 48;
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(100, 142);
            this.txtqtd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(96, 23);
            this.txtqtd.TabIndex = 47;
            this.txtqtd.TextChanged += new System.EventHandler(this.txtendereco_TextChanged);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(100, 54);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(387, 23);
            this.txtdescricao.TabIndex = 36;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(100, 17);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(139, 23);
            this.txtcodigo.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(3, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "QTD Estoque";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(14, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Preço:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label18.Location = new System.Drawing.Point(9, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "Descrição:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label21.Location = new System.Drawing.Point(16, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 17);
            this.label21.TabIndex = 29;
            this.label21.Text = "Fornecedor";
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
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label23.Location = new System.Drawing.Point(9, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 17);
            this.label23.TabIndex = 24;
            this.label23.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelaProduto);
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.txtpesquisa);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(519, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabelaProduto
            // 
            this.tabelaProduto.AllowUserToAddRows = false;
            this.tabelaProduto.AllowUserToDeleteRows = false;
            this.tabelaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProduto.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabelaProduto.Location = new System.Drawing.Point(3, 130);
            this.tabelaProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabelaProduto.Name = "tabelaProduto";
            this.tabelaProduto.ReadOnly = true;
            this.tabelaProduto.Size = new System.Drawing.Size(516, 252);
            this.tabelaProduto.TabIndex = 49;
            this.tabelaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaProduto_CellContentClick);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(336, 92);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(142, 30);
            this.btnpesquisar.TabIndex = 48;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(82, 58);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(396, 23);
            this.txtpesquisa.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(15, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 46;
            this.label12.Text = "Nome:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(137, 512);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 26);
            this.btnnovo.TabIndex = 53;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(236, 512);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 26);
            this.btnsalvar.TabIndex = 54;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(342, 512);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 26);
            this.btnexcluir.TabIndex = 56;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(449, 512);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 26);
            this.btneditar.TabIndex = 57;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 553);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabProduto);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProdutos";
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProduto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabProduto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tabelaProduto;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.TextBox txtpreco;
    }
}