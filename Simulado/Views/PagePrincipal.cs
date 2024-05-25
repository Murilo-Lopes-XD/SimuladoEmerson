using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Simulado.Controller;
using Simulado.Views;

namespace Simulado
{
    public partial class PagePrincipal : Form
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string senha = textBox2.Text;

            profControll controll = new profControll();

            if (controll.Verificar(email, senha) == true)
            {
                PageProfessor prof = new PageProfessor();
                prof.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERRO", "ERRISSIMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
