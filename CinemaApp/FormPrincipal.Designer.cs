namespace CinemaApp
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            gêneroToolStripMenuItem = new ToolStripMenuItem();
            filmeToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            seçãoToolStripMenuItem = new ToolStripMenuItem();
            ingressoToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, vendaToolStripMenuItem });
            menuStrip1.Location = new Point(3, 78);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gêneroToolStripMenuItem, filmeToolStripMenuItem, salaToolStripMenuItem, seçãoToolStripMenuItem, ingressoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // gêneroToolStripMenuItem
            // 
            gêneroToolStripMenuItem.Name = "gêneroToolStripMenuItem";
            gêneroToolStripMenuItem.Size = new Size(224, 26);
            gêneroToolStripMenuItem.Text = "Gênero";
            gêneroToolStripMenuItem.Click += gêneroToolStripMenuItem_Click;
            // 
            // filmeToolStripMenuItem
            // 
            filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            filmeToolStripMenuItem.Size = new Size(224, 26);
            filmeToolStripMenuItem.Text = "Filme";
            filmeToolStripMenuItem.Click += filmeToolStripMenuItem_Click;
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(224, 26);
            salaToolStripMenuItem.Text = "Sala";
            // 
            // seçãoToolStripMenuItem
            // 
            seçãoToolStripMenuItem.Name = "seçãoToolStripMenuItem";
            seçãoToolStripMenuItem.Size = new Size(224, 26);
            seçãoToolStripMenuItem.Text = "Seção";
            // 
            // ingressoToolStripMenuItem
            // 
            ingressoToolStripMenuItem.Name = "ingressoToolStripMenuItem";
            ingressoToolStripMenuItem.Size = new Size(224, 26);
            ingressoToolStripMenuItem.Text = "Ingresso";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(64, 24);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Sistema de Gerenciamento de Cinemas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem gêneroToolStripMenuItem;
        private ToolStripMenuItem filmeToolStripMenuItem;
        private ToolStripMenuItem salaToolStripMenuItem;
        private ToolStripMenuItem seçãoToolStripMenuItem;
        private ToolStripMenuItem ingressoToolStripMenuItem;
    }
}