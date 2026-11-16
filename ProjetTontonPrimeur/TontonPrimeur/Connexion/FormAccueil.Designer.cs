namespace TontonPrimeur
{
    partial class FormAccueil
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
            imageTiPrimeur = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imageTiPrimeur).BeginInit();
            SuspendLayout();
            // 
            // imageTiPrimeur
            // 
            imageTiPrimeur.Image = Properties.Resources.tiprimeur;
            imageTiPrimeur.Location = new Point(132, 82);
            imageTiPrimeur.Name = "imageTiPrimeur";
            imageTiPrimeur.Size = new Size(100, 50);
            imageTiPrimeur.SizeMode = PictureBoxSizeMode.Zoom;
            imageTiPrimeur.TabIndex = 0;
            imageTiPrimeur.TabStop = false;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imageTiPrimeur);
            Name = "FormAccueil";
            Text = "FormAccueil";
            WindowState = FormWindowState.Maximized;
            Load += FormAccueil_Load;
            ((System.ComponentModel.ISupportInitialize)imageTiPrimeur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imageTiPrimeur;
    }
}