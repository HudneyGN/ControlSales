﻿
namespace SalesControl.br.com.project.view
{
    partial class Frmpagamentos
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
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinheiro.Location = new System.Drawing.Point(211, 116);
            this.txtdinheiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(178, 47);
            this.txtdinheiro.TabIndex = 60;
            this.txtdinheiro.TextChanged += new System.EventHandler(this.txtdinheiro_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(49, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 39);
            this.label14.TabIndex = 59;
            this.label14.Text = "Dinheiro:";
            // 
            // txtcartao
            // 
            this.txtcartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcartao.Location = new System.Drawing.Point(211, 171);
            this.txtcartao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(178, 47);
            this.txtcartao.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(74, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 39);
            this.label3.TabIndex = 61;
            this.label3.Text = "Cartão:";
            // 
            // txttroco
            // 
            this.txttroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(211, 226);
            this.txttroco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttroco.Name = "txttroco";
            this.txttroco.ReadOnly = true;
            this.txttroco.Size = new System.Drawing.Size(178, 47);
            this.txttroco.TabIndex = 64;
            this.txttroco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(89, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 39);
            this.label4.TabIndex = 63;
            this.label4.Text = "Troco:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(211, 281);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(178, 47);
            this.txttotal.TabIndex = 66;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(101, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 39);
            this.label5.TabIndex = 65;
            this.label5.Text = "Total:";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnfinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.White;
            this.btnfinalizar.Location = new System.Drawing.Point(56, 363);
            this.btnfinalizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(333, 51);
            this.btnfinalizar.TabIndex = 67;
            this.btnfinalizar.Text = "Finalizar Venda";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(395, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 39);
            this.label6.TabIndex = 68;
            this.label6.Text = "OBS:";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtobs.Location = new System.Drawing.Point(489, 124);
            this.txtobs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(207, 290);
            this.txtobs.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(203, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 44);
            this.label1.TabIndex = 70;
            this.label1.Text = "Pagamento";
            // 
            // Frmpagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesControl.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcartao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.label14);
            this.Name = "Frmpagamentos";
            this.Text = "Tela Pagamentos";
            this.Load += new System.EventHandler(this.Frmpagamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfinalizar;
        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label1;
    }
}