using CinemaApp.Base;
using CinemaApp.Models;
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
    public partial class CadastroFilme : CadastroBase
    {

        private readonly IBaseService<Filme> _filmeService;
        private readonly IBaseService<Genero> _generoService;
        private List<FilmeViewModel> _filmes;
        private List<GeneroViewModel> _generos;

        public CadastroFilme(IBaseService<Filme> filmeService, IBaseService<Genero> generoService)
        {
            _filmeService = filmeService;
            _generoService = generoService;
            InitializeComponent();
            CarregaComboGeneros();
        }

        private void CarregaComboGeneros()
        {
            cbGenero.DisplayMember = nameof(GeneroViewModel.Nome);
            cbGenero.ValueMember = nameof(GeneroViewModel.Id);
            _generos = _generoService.ReadAll<GeneroViewModel>().ToList();
            cbGenero.DataSource = null;
            cbGenero.DataSource = _generos;
            cbGenero.SelectedIndex = -1;
        }

        private void PreencheObjeto(Filme filme)
        {
            filme.Nome = txtNomeFilme.Text;
            filme.Classificacao = cbClassificacao.SelectedItem?.ToString();
            filme.Genero = _generoService.ReadbyId<Genero>((int)cbGenero.SelectedValue);
            filme.Duracao = Convert.ToInt32(numDuracao.Value);
        }

        private void PreencheTela(Filme filme)
        {
            txtNomeFilme.Text = filme.Nome;
            cbClassificacao.SelectedItem = filme.Classificacao;
            cbGenero.SelectedItem = _generos.FirstOrDefault(g => g.Id == filme.Genero?.Id);
            numDuracao.Value = filme.Duracao;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtBoxId.Text);
                    var filme = _filmeService.ReadbyId<Filme>(id);
                    PreencheObjeto(filme);
                    _filmeService.Update<Filme, Filme, FilmeValidator>(filme);
                }
                else
                {
                    var filme = new Filme();
                    PreencheObjeto(filme);
                    _filmeService.Create<Filme, Filme, FilmeValidator>(filme);
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
                _filmeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregarGrid()
        {
            _filmes = _filmeService.ReadAll<FilmeViewModel>().ToList();
            dataGridView1.DataSource = _filmes;

            if (dataGridView1.Columns["Nome"] is not null)
                dataGridView1.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridView1.Columns["GeneroId"] is not null)
                dataGridView1.Columns["GeneroId"].Visible = false;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var filme = _filmeService.ReadbyId<Filme>(id);

            txtBoxId.Text = filme.Id.ToString();
            PreencheTela(filme);
        }

    }
}
