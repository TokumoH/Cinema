namespace CinemaApp.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            materialTabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialBtnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            materialBtnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tabPageConsulta = new TabPage();
            materialBtnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            materialBtnEditar = new ReaLTaiizor.Controls.MaterialButton();
            materialBtnNovo = new ReaLTaiizor.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            imageList = new ImageList(components);
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialTabControl.Controls.Add(tabPageCadastro);
            materialTabControl.Controls.Add(tabPageConsulta);
            materialTabControl.Depth = 0;
            materialTabControl.ImageList = imageList;
            materialTabControl.Location = new Point(3, 77);
            materialTabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl.Multiline = true;
            materialTabControl.Name = "materialTabControl";
            materialTabControl.SelectedIndex = 0;
            materialTabControl.Size = new Size(739, 351);
            materialTabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(materialBtnSalvar);
            tabPageCadastro.Controls.Add(materialBtnCancelar);
            tabPageCadastro.ImageKey = "icone-fichier-document-noir.png";
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(731, 318);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtBoxId
            // 
            txtBoxId.AnimateReadOnly = false;
            txtBoxId.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxId.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxId.BackgroundImageLayout = ImageLayout.None;
            txtBoxId.CharacterCasing = CharacterCasing.Normal;
            txtBoxId.Depth = 0;
            txtBoxId.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxId.HideSelection = true;
            txtBoxId.Hint = "Id";
            txtBoxId.LeadingIcon = null;
            txtBoxId.Location = new Point(6, 6);
            txtBoxId.MaxLength = 32767;
            txtBoxId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxId.Name = "txtBoxId";
            txtBoxId.PasswordChar = '\0';
            txtBoxId.PrefixSuffixText = null;
            txtBoxId.ReadOnly = true;
            txtBoxId.RightToLeft = RightToLeft.No;
            txtBoxId.SelectedText = "";
            txtBoxId.SelectionLength = 0;
            txtBoxId.SelectionStart = 0;
            txtBoxId.ShortcutsEnabled = true;
            txtBoxId.Size = new Size(57, 60);
            txtBoxId.TabIndex = 6;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // materialBtnSalvar
            // 
            materialBtnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialBtnSalvar.AutoSize = false;
            materialBtnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialBtnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialBtnSalvar.Depth = 0;
            materialBtnSalvar.HighEmphasis = true;
            materialBtnSalvar.Icon = null;
            materialBtnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialBtnSalvar.Location = new Point(614, 277);
            materialBtnSalvar.Margin = new Padding(4, 6, 4, 6);
            materialBtnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialBtnSalvar.Name = "materialBtnSalvar";
            materialBtnSalvar.NoAccentTextColor = Color.Empty;
            materialBtnSalvar.Size = new Size(110, 35);
            materialBtnSalvar.TabIndex = 4;
            materialBtnSalvar.Text = "Salvar";
            materialBtnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialBtnSalvar.UseAccentColor = false;
            materialBtnSalvar.UseVisualStyleBackColor = true;
            materialBtnSalvar.Click += materialBtnSalvar_Click;
            // 
            // materialBtnCancelar
            // 
            materialBtnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialBtnCancelar.AutoSize = false;
            materialBtnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialBtnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialBtnCancelar.Depth = 0;
            materialBtnCancelar.HighEmphasis = true;
            materialBtnCancelar.Icon = null;
            materialBtnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialBtnCancelar.Location = new Point(496, 277);
            materialBtnCancelar.Margin = new Padding(4, 6, 4, 6);
            materialBtnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialBtnCancelar.Name = "materialBtnCancelar";
            materialBtnCancelar.NoAccentTextColor = Color.Empty;
            materialBtnCancelar.Size = new Size(110, 35);
            materialBtnCancelar.TabIndex = 3;
            materialBtnCancelar.Text = "Cancelar";
            materialBtnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialBtnCancelar.UseAccentColor = false;
            materialBtnCancelar.UseVisualStyleBackColor = true;
            materialBtnCancelar.Click += materialBtnCancelar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(materialBtnExcluir);
            tabPageConsulta.Controls.Add(materialBtnEditar);
            tabPageConsulta.Controls.Add(materialBtnNovo);
            tabPageConsulta.Controls.Add(dataGridView1);
            tabPageConsulta.ImageKey = "download.png";
            tabPageConsulta.Location = new Point(4, 29);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(731, 318);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter_1;
            // 
            // materialBtnExcluir
            // 
            materialBtnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialBtnExcluir.AutoSize = false;
            materialBtnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialBtnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialBtnExcluir.Depth = 0;
            materialBtnExcluir.HighEmphasis = true;
            materialBtnExcluir.Icon = null;
            materialBtnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialBtnExcluir.Location = new Point(609, 272);
            materialBtnExcluir.Margin = new Padding(4, 6, 4, 6);
            materialBtnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialBtnExcluir.Name = "materialBtnExcluir";
            materialBtnExcluir.NoAccentTextColor = Color.Empty;
            materialBtnExcluir.Size = new Size(110, 35);
            materialBtnExcluir.TabIndex = 6;
            materialBtnExcluir.Text = "Excluir";
            materialBtnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialBtnExcluir.UseAccentColor = false;
            materialBtnExcluir.UseVisualStyleBackColor = true;
            materialBtnExcluir.Click += materialBtnExcluir_Click;
            // 
            // materialBtnEditar
            // 
            materialBtnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialBtnEditar.AutoSize = false;
            materialBtnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialBtnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialBtnEditar.Depth = 0;
            materialBtnEditar.HighEmphasis = true;
            materialBtnEditar.Icon = null;
            materialBtnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialBtnEditar.Location = new Point(491, 272);
            materialBtnEditar.Margin = new Padding(4, 6, 4, 6);
            materialBtnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialBtnEditar.Name = "materialBtnEditar";
            materialBtnEditar.NoAccentTextColor = Color.Empty;
            materialBtnEditar.Size = new Size(110, 35);
            materialBtnEditar.TabIndex = 5;
            materialBtnEditar.Text = "Editar";
            materialBtnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialBtnEditar.UseAccentColor = false;
            materialBtnEditar.UseVisualStyleBackColor = true;
            materialBtnEditar.Click += materialBtnEditar_Click;
            // 
            // materialBtnNovo
            // 
            materialBtnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            materialBtnNovo.AutoSize = false;
            materialBtnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialBtnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialBtnNovo.Depth = 0;
            materialBtnNovo.HighEmphasis = true;
            materialBtnNovo.Icon = null;
            materialBtnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialBtnNovo.Location = new Point(373, 272);
            materialBtnNovo.Margin = new Padding(4, 6, 4, 6);
            materialBtnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialBtnNovo.Name = "materialBtnNovo";
            materialBtnNovo.NoAccentTextColor = Color.Empty;
            materialBtnNovo.Size = new Size(110, 35);
            materialBtnNovo.TabIndex = 4;
            materialBtnNovo.Text = "Novo";
            materialBtnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialBtnNovo.UseAccentColor = false;
            materialBtnNovo.UseVisualStyleBackColor = true;
            materialBtnNovo.Click += materialBtnNovo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(722, 257);
            dataGridView1.TabIndex = 1;
            dataGridView1.Enter += tabPageConsulta_Enter_1;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "icone-fichier-document-noir.png");
            imageList.Images.SetKeyName(1, "download.png");
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 434);
            Controls.Add(materialTabControl);
            Name = "CadastroBase";
            Text = "CadastroBase";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList;
        protected TabPage tabPageCadastro;
        protected ReaLTaiizor.Controls.MaterialButton materialBtnSalvar;
        protected ReaLTaiizor.Controls.MaterialButton materialBtnCancelar;
        protected DataGridView dataGridView1;
        protected TabPage tabPageConsulta;
        protected ReaLTaiizor.Controls.MaterialButton materialBtnNovo;
        protected ReaLTaiizor.Controls.MaterialButton materialBtnExcluir;
        protected ReaLTaiizor.Controls.MaterialButton materialBtnEditar;
        protected ReaLTaiizor.Controls.MaterialTabControl materialTabControl;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
    }
}