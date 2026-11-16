namespace TontonPrimeur
{
    partial class FormConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dfbbToolStripMenuItem = new ToolStripMenuItem();
            articlesToolStripMenuItem = new ToolStripMenuItem();
            fournisseursToolStripMenuItem = new ToolStripMenuItem();
            accueilToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { accueilToolStripMenuItem, dfbbToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(868, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // dfbbToolStripMenuItem
            // 
            dfbbToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { articlesToolStripMenuItem, fournisseursToolStripMenuItem });
            dfbbToolStripMenuItem.Name = "dfbbToolStripMenuItem";
            dfbbToolStripMenuItem.Size = new Size(70, 20);
            dfbbToolStripMenuItem.Text = "Affichage";
            // 
            // articlesToolStripMenuItem
            // 
            articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            articlesToolStripMenuItem.Size = new Size(180, 22);
            articlesToolStripMenuItem.Text = "Articles";
            articlesToolStripMenuItem.Click += articlesToolStripMenuItem_Click;
            // 
            // fournisseursToolStripMenuItem
            // 
            fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            fournisseursToolStripMenuItem.Size = new Size(180, 22);
            fournisseursToolStripMenuItem.Text = "Fournisseurs";
            fournisseursToolStripMenuItem.Click += fournisseursToolStripMenuItem_Click;
            // 
            // accueilToolStripMenuItem
            // 
            accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            accueilToolStripMenuItem.Size = new Size(58, 20);
            accueilToolStripMenuItem.Text = "Accueil";
            accueilToolStripMenuItem.Click += accueilToolStripMenuItem_Click;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormConnexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dfbbToolStripMenuItem;
        private ToolStripMenuItem articlesToolStripMenuItem;
        private ToolStripMenuItem fournisseursToolStripMenuItem;
        private ToolStripMenuItem accueilToolStripMenuItem;
    }
}
