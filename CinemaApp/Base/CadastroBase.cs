using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Base
{
    public partial class CadastroBase : MaterialForm

    {
        #region declaracoes
        protected bool IsEditMode = false;

        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void materialBtnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente cancelar?", "Cancelar",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl.SelectedIndex = 1;
            }
        }

        private void materialBtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }


        private void materialBtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void materialBtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void materialBtnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region metodos

        protected virtual void CarregarGrid()
        {
            if (DesignMode) return;
            throw new NotImplementedException();
        }

        private void LimpaCampos()
        {
            foreach (Control control in materialTabControl.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                else if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void Salvar()
        {
            throw new NotImplementedException();
        }

        protected virtual void Cancelar()
        {
            throw new NotImplementedException();
        }
        protected virtual void Deletar(int id)
        {
            throw new NotImplementedException();
        }
        protected virtual void Novo()
        {
            LimpaCampos();
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Focus();
        }
        protected virtual void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var row = dataGridView1.SelectedRows[0];
                CarregarRegistro(row);
                materialTabControl.SelectedIndex = 0;
                materialTabControl.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um registro para editar!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      

        protected virtual void CarregarRegistro(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void tabPageConsulta_Enter_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
