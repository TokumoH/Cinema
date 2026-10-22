namespace CinemaApp.Cadastros
{
    partial class CadastroGenero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxNome);
            tabPageCadastro.Size = new Size(731, 319);
            tabPageCadastro.Controls.SetChildIndex(materialBtnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(materialBtnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxNome, 0);
            // 
            // materialBtnSalvar
            // 
            materialBtnSalvar.Location = new Point(614, 278);
            // 
            // materialBtnCancelar
            // 
            materialBtnCancelar.Location = new Point(496, 278);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(731, 319);
            // 
            // materialBtnNovo
            // 
            materialBtnNovo.Location = new Point(373, 273);
            // 
            // materialBtnExcluir
            // 
            materialBtnExcluir.Location = new Point(609, 273);
            // 
            // materialBtnEditar
            // 
            materialBtnEditar.Location = new Point(491, 273);
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(739, 352);
            materialTabControl.SizeMode = TabSizeMode.FillToRight;
            // 
            // txtBoxNome
            // 
            txtBoxNome.AnimateReadOnly = false;
            txtBoxNome.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxNome.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxNome.BackgroundImageLayout = ImageLayout.None;
            txtBoxNome.CharacterCasing = CharacterCasing.Normal;
            txtBoxNome.Depth = 0;
            txtBoxNome.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxNome.HideSelection = true;
            txtBoxNome.Hint = "Nome";
            txtBoxNome.LeadingIcon = null;
            txtBoxNome.Location = new Point(6, 89);
            txtBoxNome.MaxLength = 32767;
            txtBoxNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.PasswordChar = '\0';
            txtBoxNome.PrefixSuffixText = null;
            txtBoxNome.ReadOnly = false;
            txtBoxNome.RightToLeft = RightToLeft.No;
            txtBoxNome.SelectedText = "";
            txtBoxNome.SelectionLength = 0;
            txtBoxNome.SelectionStart = 0;
            txtBoxNome.ShortcutsEnabled = true;
            txtBoxNome.Size = new Size(343, 60);
            txtBoxNome.TabIndex = 6;
            txtBoxNome.TabStop = false;
            txtBoxNome.TextAlign = HorizontalAlignment.Left;
            txtBoxNome.TrailingIcon = null;
            txtBoxNome.UseSystemPasswordChar = false;
            // 
            // CadastroGenero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(974, 508);
            Name = "CadastroGenero";
            Text = "CadastroGenero";
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxNome;
    }
}