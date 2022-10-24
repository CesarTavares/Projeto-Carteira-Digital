using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaCarteira
{
    public partial class frmMenu : Form
    {
     

        public frmMenu()
        {
            InitializeComponent();

            //carrega as contas
           // cl_geral.ConstroiListaContas();

            //apresenta versão do programa
            label_versao.Text = cl_geral.versao;
            label_titulo.Text = cl_geral.titulo;
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContas frmCadContas = new frmContas();
            frmCadContas.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor frmCadFornecedor = new frmFornecedor();
            frmCadFornecedor.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmCadUsuario = new frmUsuario();
            frmCadUsuario.ShowDialog();
        }

        private void lançamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLançamento frmCadLancamento = new frmLançamento();
            frmCadLancamento.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmCadSobre = new frmSobre();
            frmCadSobre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pergunta se deseja sair da aplicação
            if (MessageBox.Show("Deseja sair da Aplicação?", "SAIR!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) return;
           
            Application.Exit();
        }

        private void movimentaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMovimentacao frmCadMovim = new frmMovimentacao();
            frmCadMovim.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
