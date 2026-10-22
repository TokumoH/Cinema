using CinemaApp.Cadastros;
using CinemaApp.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class FormPrincipal : MaterialForm

    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServiceProvider.GetService<TFormulario>();
            if (ConfigureDI.ServiceProvider != null)
            {
                var form = ConfigureDI.ServiceProvider.GetService<TFormulario>();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show($"Não foi possível abrir o {typeof(TFormulario).Name}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroGenero>();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFilme>();
        }
    }
}
