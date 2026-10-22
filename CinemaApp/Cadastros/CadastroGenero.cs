using CinemaApp.Base;
using CinemaDomain;
using CinemaServices.Base;
using CinemaServices.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class CadastroGenero : CadastroBase
    {
        private IBaseService<Genero> _generoService;
        private List<Genero> _generos;
        public CadastroGenero(IBaseService<Genero> generoService)
        {
            _generoService = generoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Genero genero)
        {
            genero.Nome = txtBoxNome.Text;
        }

        private void PreencheTela(Genero genero)
        {
            txtBoxNome.Text = genero.Nome;
            txtBoxId.Text = genero.Id.ToString();
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtBoxId.Text);
                    var genero = _generoService.ReadbyId<Genero>(id);
                    PreencheObjeto(genero);
                    _generoService.Update<Genero, Genero, GeneroValidator>(genero);
                }
                else
                {
                    var genero = new Genero();
                    PreencheObjeto(genero);
                    _generoService.Create<Genero, Genero, GeneroValidator>(genero);
                }
                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _generoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void CarregarGrid()
        {
            _generos = _generoService.ReadAll<Genero>().ToList();
            dataGridView1.DataSource = _generos;
            dataGridView1.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            txtBoxId.Text = row.Cells["Id"].Value.ToString();
            txtBoxNome.Text = row.Cells["Nome"].Value.ToString();
        }

        

      
    }
}
