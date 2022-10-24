using System;
using System.Windows.Forms;

namespace MinhaCarteira
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            //label_versao.Text = cl_geral.versao;
            //label_titulo.Text = cl_geral.titulo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
