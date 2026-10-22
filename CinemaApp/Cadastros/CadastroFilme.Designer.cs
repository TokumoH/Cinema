namespace CinemaApp.Cadastros
{
    partial class CadastroFilme
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
            cbClassificacao = new ReaLTaiizor.Controls.MaterialComboBox();
            cbGenero = new ReaLTaiizor.Controls.MaterialComboBox();
            numDuracao = new ReaLTaiizor.Controls.MetroNumeric();
            txtNomeFilme = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtNomeFilme);
            tabPageCadastro.Controls.Add(numDuracao);
            tabPageCadastro.Controls.Add(cbGenero);
            tabPageCadastro.Controls.Add(cbClassificacao);
            tabPageCadastro.Controls.SetChildIndex(materialBtnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(materialBtnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            tabPageCadastro.Controls.SetChildIndex(cbClassificacao, 0);
            tabPageCadastro.Controls.SetChildIndex(cbGenero, 0);
            tabPageCadastro.Controls.SetChildIndex(numDuracao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeFilme, 0);
            // 
            // txtBoxId
            // 
            txtBoxId.Location = new Point(11, 6);
            // 
            // cbClassificacao
            // 
            cbClassificacao.AutoResize = false;
            cbClassificacao.BackColor = Color.FromArgb(255, 255, 255);
            cbClassificacao.Depth = 0;
            cbClassificacao.DrawMode = DrawMode.OwnerDrawVariable;
            cbClassificacao.DropDownHeight = 218;
            cbClassificacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClassificacao.DropDownWidth = 121;
            cbClassificacao.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbClassificacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbClassificacao.FormattingEnabled = true;
            cbClassificacao.IntegralHeight = false;
            cbClassificacao.ItemHeight = 54;
            cbClassificacao.Location = new Point(11, 161);
            cbClassificacao.MaxDropDownItems = 4;
            cbClassificacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbClassificacao.Name = "cbClassificacao";
            cbClassificacao.Size = new Size(171, 60);
            cbClassificacao.StartIndex = 0;
            cbClassificacao.TabIndex = 7;
            // 
            // cbGenero
            // 
            cbGenero.AutoResize = false;
            cbGenero.BackColor = Color.FromArgb(255, 255, 255);
            cbGenero.Depth = 0;
            cbGenero.DrawMode = DrawMode.OwnerDrawVariable;
            cbGenero.DropDownHeight = 218;
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.DropDownWidth = 121;
            cbGenero.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbGenero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbGenero.FormattingEnabled = true;
            cbGenero.IntegralHeight = false;
            cbGenero.ItemHeight = 54;
            cbGenero.Location = new Point(198, 161);
            cbGenero.MaxDropDownItems = 4;
            cbGenero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(372, 60);
            cbGenero.StartIndex = 0;
            cbGenero.TabIndex = 8;
            // 
            // numDuracao
            // 
            numDuracao.BackColor = Color.Transparent;
            numDuracao.BackgroundColor = Color.Empty;
            numDuracao.BorderColor = Color.FromArgb(150, 150, 150);
            numDuracao.Decrement = 1;
            numDuracao.DisabledBackColor = Color.FromArgb(204, 204, 204);
            numDuracao.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            numDuracao.DisabledForeColor = Color.FromArgb(136, 136, 136);
            numDuracao.Font = new Font("Microsoft Sans Serif", 10F);
            numDuracao.HoldInterval = 10;
            numDuracao.Increment = 1;
            numDuracao.IsDerivedStyle = true;
            numDuracao.Location = new Point(576, 180);
            numDuracao.Maximum = 100;
            numDuracao.Minimum = 0;
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(146, 26);
            numDuracao.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            numDuracao.StyleManager = null;
            numDuracao.SymbolsColor = Color.FromArgb(128, 128, 128);
            numDuracao.TabIndex = 9;
            numDuracao.Text = "metroNumeric1";
            numDuracao.ThemeAuthor = "Taiizor";
            numDuracao.ThemeName = "MetroLight";
            numDuracao.Value = 0;
            // 
            // txtNomeFilme
            // 
            txtNomeFilme.AnimateReadOnly = false;
            txtNomeFilme.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeFilme.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeFilme.BackgroundImageLayout = ImageLayout.None;
            txtNomeFilme.CharacterCasing = CharacterCasing.Normal;
            txtNomeFilme.Depth = 0;
            txtNomeFilme.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeFilme.HideSelection = true;
            txtNomeFilme.Hint = "Nome";
            txtNomeFilme.LeadingIcon = null;
            txtNomeFilme.Location = new Point(11, 83);
            txtNomeFilme.MaxLength = 32767;
            txtNomeFilme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeFilme.Name = "txtNomeFilme";
            txtNomeFilme.PasswordChar = '\0';
            txtNomeFilme.PrefixSuffixText = null;
            txtNomeFilme.ReadOnly = false;
            txtNomeFilme.RightToLeft = RightToLeft.No;
            txtNomeFilme.SelectedText = "";
            txtNomeFilme.SelectionLength = 0;
            txtNomeFilme.SelectionStart = 0;
            txtNomeFilme.ShortcutsEnabled = true;
            txtNomeFilme.Size = new Size(517, 60);
            txtNomeFilme.TabIndex = 10;
            txtNomeFilme.TabStop = false;
            txtNomeFilme.TextAlign = HorizontalAlignment.Left;
            txtNomeFilme.TrailingIcon = null;
            txtNomeFilme.UseSystemPasswordChar = false;
            // 
            // CadastroFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "CadastroFilme";
            Text = "CadastroFilme";
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeFilme;
        private ReaLTaiizor.Controls.MetroNumeric numDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox cbGenero;
        private ReaLTaiizor.Controls.MaterialComboBox cbClassificacao;
    }
}