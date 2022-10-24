using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace MinhaCarteira
{
    public partial class frmContas : Form
    {
        int id_conta;
        bool editar;

        public frmContas(int id_conta = -1)
        {
            InitializeComponent();
            label_versao.Text = cl_geral.versao;
            label_titulo.Text = cl_geral.titulo;
            this.id_conta = id_conta;

            //definir se vou adicionar ou editar registro
            editar = id_conta == -1 ? false : true;

            //ConstroiLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContas_Load(object sender, EventArgs e)
        {
            ConstruirGrade();
            //apresenta os dados do contato se necessario
            if (editar)
                ApresentaConta();
        }
        private void ConstruirGrade()
        {
            //constroi a grade de registros

            //ligar ao BD
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + cl_geral.base_dados);
            ligacao.Open();

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contas", ligacao);
            DataTable dadosCarteira = new DataTable();
            adaptador.Fill(dadosCarteira);
            dgv_resultados.DataSource = dadosCarteira;

            //apresenta um numero de registro no BD
            label_num_registros.Text = "Registros: " + dgv_resultados.Rows.Count;

            //Esconder Colunas no DGV
            //id_conta | atualizacao
            dgv_resultados.Columns["id_conta"].Visible = false;
            dgv_resultados.Columns["atualizacao"].Visible = false;

            //alterar as dimensões das colunas
            dgv_resultados.Columns["descricao"].Width = 250;
            dgv_resultados.Columns["fornecedor"].Width = 160;
            dgv_resultados.Columns["dataVenc"].Width = 60;

            //Controla a disponibilidade dos comandos
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }

        private void ApresentaConta()
        {
            //Apresenta a conta que vai ser editado.
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + cl_geral.base_dados);
            ligacao.Open();
            DataTable dadosCarteira = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contas WHERE id_conta = " + id_conta, ligacao);
            adaptador.Fill(dadosCarteira);
            ligacao.Dispose();

            //colocar os dados nos textbox
            txt_descricao.Text = dadosCarteira.Rows[0]["descricao"].ToString();
            txt_fornecedor.Text = dadosCarteira.Rows[0]["fornecedor"].ToString();
            txt_datavenc.Text = dadosCarteira.Rows[0]["datavenc"].ToString();
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + cl_geral.base_dados);
            ligacao.Open();
           

            //grava novo registro ou edita registro existente

            #region verificações...
            //verificar se os campos estão preenchidos
            if (txt_descricao.Text == "" || txt_fornecedor.Text == "" || txt_datavenc.Text == "")
            {
                MessageBox.Show("OBRIGATÓRIO preencher todos os campos.");
                return;
            }
            #endregion

            #region NOVA CONTA
            if (!editar)
            {
                //buscar o id_conta disponivel
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT MAX(id_conta) AS maxid FROM contas", ligacao);
                                
                DataTable dadosCarteira = new DataTable();
                adaptador.Fill(dadosCarteira);

                //verificar se o valor é null
                if (DBNull.Value.Equals(dadosCarteira.Rows[0][0]))
                    id_conta = 0;
                else
                    id_conta = Convert.ToInt32(dadosCarteira.Rows[0][0]) + 1;

                //gravar o novo contato na base de dados
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros
                comando.Parameters.AddWithValue("@id_conta", id_conta);
                comando.Parameters.AddWithValue("@descricao", txt_descricao.Text);
                comando.Parameters.AddWithValue("@fornecedor", txt_fornecedor.Text);
                comando.Parameters.AddWithValue("@data_venc", txt_datavenc.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se já existe uma conta com a mesma descrição
                adaptador = new SqlCeDataAdapter();
                dadosCarteira = new DataTable();
                comando.CommandText = "SELECT * FROM contas WHERE descricao = @descricao AND fornecedor = @fornecedor";
                adaptador.SelectCommand = comando;
                adaptador.Fill(dadosCarteira);
                if(dadosCarteira.Rows.Count != 0)
                {
                    //MessageBox.Show("Já existe um registro com o mesmo nome e fornecedor.");
                    //return;
                    if (MessageBox.Show("Já existe um registro com o mesmo nome e fornecedor." + Environment.NewLine +
                        "Deseja gravar mesmo assim?", "ATENÇÃO",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;                    
                }

                //texto da query
                comando.CommandText = "INSERT INTO contas VALUES(" +
                    "@id_conta, @descricao, @fornecedor, @data_venc, @atualizacao)";
               
                comando.ExecuteNonQuery();
                comando.Dispose();
                ligacao.Dispose();

                MessageBox.Show("Contas adicionadas com sucesso!");
                ConstruirGrade();
                //Limpa campos
                txt_descricao.Text = "";
                txt_fornecedor.Text = "";
                txt_datavenc.Text = "";
                txt_descricao.Focus();
            }

            #endregion

            #region EDITAR CONTA
            else
            {
                //edita a conta na base de dados

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros
                comando.Parameters.AddWithValue("@id_conta", id_conta);
                comando.Parameters.AddWithValue("@descricao", txt_descricao.Text);
                comando.Parameters.AddWithValue("@fornecedor", txt_fornecedor.Text);
                comando.Parameters.AddWithValue("@data_venc", txt_datavenc.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se existe registro com a mesma descrição e com id_conta diferente
                DataTable dadosCarteira = new DataTable();                
                comando.CommandText = "SELECT * FROM contas WHERE descricao = @descricao AND id_conta <> @id_conta";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(dadosCarteira);
                if(dadosCarteira.Rows.Count != 0)
                {
                    //foi encontrado um registro com a mesma descrição
                    if (MessageBox.Show("Já existe um registro com o mesmo nome." + Environment.NewLine +
                        "Deseja gravar mesmo assim?", "ATENÇÃO",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                //editar o registro selecionado
                comando.CommandText = "UPDATE contas SET " +
                                        "descricao = @descricao, " +
                                        "fornecedor = @fornecedor, " +
                                        "datavenc = @data_venc," +
                                        "atualizacao = @atualizacao " +
                                        "WHERE id_conta = @id_conta";
                comando.ExecuteNonQuery();

                //fechar o quadro
                this.Close();

            }
            #endregion
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //eliminar a linha selecionada
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + cl_geral.base_dados);
            ligacao.Open();
            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contas WHERE id_conta = " + id_conta, ligacao);
            comando.ExecuteNonQuery();
            ligacao.Dispose();
            comando.Dispose();


            //reconstruir a grade de contatos
            ConstruirGrade();
        }

        private void dgv_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_conta = Convert.ToInt32(dgv_resultados.Rows[e.RowIndex].Cells["id_conta"].Value);
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {
            // edita o registro selecionado
            frmContas f = new frmContas(id_conta);
            f.ShowDialog();

            //atualizar a grade de contatos
            ConstruirGrade();
        }
    }
}



