using Simulado.Controller;
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
    public partial class PageCadastrarTurmas : Form
    {
        public PageCadastrarTurmas()
        {
            InitializeComponent();
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            turController controleturma = new turController();
            controleturma.InserirTurma(txtNumeroTurma.Text, txtNomeTurma.Text, txtNomeProfessor.Text);
            MessageBox.Show("Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            turController controleturma = new turController();
            controleturma.AtualizarTurma(Convert.ToInt32(txtID.Text) ,txtNumeroTurma.Text, txtNomeTurma.Text, txtNomeProfessor.Text);
            MessageBox.Show("Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            turController controleturma = new turController();
            controleturma.ExcluirTurma(Convert.ToInt32(txtID.Text));
            MessageBox.Show("Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            turController controleturma = new turController();
            controleturma.LocalizarTurma(Convert.ToInt32(txtID.Text));
            
        }
    }
}
