
namespace MinhaCarteira
{
    partial class frmContas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_num_registros = new System.Windows.Forms.Label();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_voltar = new System.Windows.Forms.Button();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Descricao = new System.Windows.Forms.Label();
            this.label_Fornecedor = new System.Windows.Forms.Label();
            this.label_data_dia = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_datavenc = new System.Windows.Forms.TextBox();
            this.label_lista = new System.Windows.Forms.Label();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.dgv_resultados = new System.Windows.Forms.DataGridView();
            this.label_titulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Silver;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(119, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(424, 60);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Minha Carteira\r\nCadastro de Contas\r\n";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label_num_registros);
            this.panel2.Controls.Add(this.cmd_editar);
            this.panel2.Controls.Add(this.cmd_voltar);
            this.panel2.Controls.Add(this.cmd_apagar);
            this.panel2.Location = new System.Drawing.Point(13, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 51);
            this.panel2.TabIndex = 10;
            // 
            // label_num_registros
            // 
            this.label_num_registros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_registros.Location = new System.Drawing.Point(3, 12);
            this.label_num_registros.Name = "label_num_registros";
            this.label_num_registros.Size = new System.Drawing.Size(173, 30);
            this.label_num_registros.TabIndex = 0;
            this.label_num_registros.Text = "Registros:";
            // 
            // cmd_editar
            // 
            this.cmd_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_editar.Location = new System.Drawing.Point(196, 12);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(90, 30);
            this.cmd_editar.TabIndex = 1;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_voltar
            // 
            this.cmd_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_voltar.Location = new System.Drawing.Point(420, 12);
            this.cmd_voltar.Name = "cmd_voltar";
            this.cmd_voltar.Size = new System.Drawing.Size(90, 30);
            this.cmd_voltar.TabIndex = 3;
            this.cmd_voltar.Text = "Voltar";
            this.cmd_voltar.UseVisualStyleBackColor = true;
            this.cmd_voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_apagar.Location = new System.Drawing.Point(308, 12);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(90, 30);
            this.cmd_apagar.TabIndex = 2;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // label_versao
            // 
            this.label_versao.AutoSize = true;
            this.label_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_versao.Location = new System.Drawing.Point(337, 654);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(205, 9);
            this.label_versao.TabIndex = 11;
            this.label_versao.Text = "Minha Carteira - Vesão 1.0.1 Cesar/Diego - Setembro 2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MinhaCarteira.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label_Descricao
            // 
            this.label_Descricao.AutoSize = true;
            this.label_Descricao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Descricao.Location = new System.Drawing.Point(16, 89);
            this.label_Descricao.Name = "label_Descricao";
            this.label_Descricao.Size = new System.Drawing.Size(111, 24);
            this.label_Descricao.TabIndex = 4;
            this.label_Descricao.Text = "Descrição";
            // 
            // label_Fornecedor
            // 
            this.label_Fornecedor.AutoSize = true;
            this.label_Fornecedor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fornecedor.Location = new System.Drawing.Point(16, 134);
            this.label_Fornecedor.Name = "label_Fornecedor";
            this.label_Fornecedor.Size = new System.Drawing.Size(127, 24);
            this.label_Fornecedor.TabIndex = 5;
            this.label_Fornecedor.Text = "Fornecedor";
            // 
            // label_data_dia
            // 
            this.label_data_dia.AutoSize = true;
            this.label_data_dia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_dia.Location = new System.Drawing.Point(16, 180);
            this.label_data_dia.Name = "label_data_dia";
            this.label_data_dia.Size = new System.Drawing.Size(152, 19);
            this.label_data_dia.TabIndex = 6;
            this.label_data_dia.Text = "Dia do Vencimento";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(156, 85);
            this.txt_descricao.MaxLength = 50;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(386, 31);
            this.txt_descricao.TabIndex = 0;
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fornecedor.Location = new System.Drawing.Point(156, 134);
            this.txt_fornecedor.MaxLength = 50;
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.Size = new System.Drawing.Size(386, 29);
            this.txt_fornecedor.TabIndex = 1;
            // 
            // txt_datavenc
            // 
            this.txt_datavenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datavenc.Location = new System.Drawing.Point(189, 173);
            this.txt_datavenc.MaxLength = 2;
            this.txt_datavenc.Name = "txt_datavenc";
            this.txt_datavenc.Size = new System.Drawing.Size(53, 29);
            this.txt_datavenc.TabIndex = 2;
            // 
            // label_lista
            // 
            this.label_lista.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lista.Location = new System.Drawing.Point(32, 225);
            this.label_lista.Name = "label_lista";
            this.label_lista.Size = new System.Drawing.Size(191, 24);
            this.label_lista.TabIndex = 7;
            this.label_lista.Text = "Lista de Contas";
            this.label_lista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gravar.Location = new System.Drawing.Point(394, 180);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(90, 30);
            this.cmd_gravar.TabIndex = 3;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // dgv_resultados
            // 
            this.dgv_resultados.AllowUserToAddRows = false;
            this.dgv_resultados.AllowUserToDeleteRows = false;
            this.dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultados.Location = new System.Drawing.Point(36, 252);
            this.dgv_resultados.MultiSelect = false;
            this.dgv_resultados.Name = "dgv_resultados";
            this.dgv_resultados.ReadOnly = true;
            this.dgv_resultados.RowHeadersVisible = false;
            this.dgv_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultados.Size = new System.Drawing.Size(474, 317);
            this.dgv_resultados.TabIndex = 17;
            this.dgv_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultados_CellClick);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Location = new System.Drawing.Point(207, 650);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(35, 13);
            this.label_titulo.TabIndex = 18;
            this.label_titulo.Text = "label1";
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 672);
            this.ControlBox = false;
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.dgv_resultados);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.label_lista);
            this.Controls.Add(this.txt_datavenc);
            this.Controls.Add(this.label_data_dia);
            this.Controls.Add(this.txt_fornecedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label_Fornecedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_Descricao);
            this.Controls.Add(this.label_versao);
            this.Name = "frmContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minha Carteira - Cadastro de Contas";
            this.Load += new System.EventHandler(this.frmContas_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmd_voltar;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Label label_num_registros;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Label label_Descricao;
        private System.Windows.Forms.Label label_Fornecedor;
        private System.Windows.Forms.Label label_data_dia;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_fornecedor;
        private System.Windows.Forms.TextBox txt_datavenc;
        private System.Windows.Forms.Label label_lista;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.DataGridView dgv_resultados;
        private System.Windows.Forms.Label label_titulo;
    }
}