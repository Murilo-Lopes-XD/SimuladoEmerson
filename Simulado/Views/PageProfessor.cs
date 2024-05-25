using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado.Views
{
    public partial class PageProfessor : Form
    {
        public PageProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            PageCadastrarTurmas cadastrarTurmas = new PageCadastrarTurmas();
            cadastrarTurmas.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
