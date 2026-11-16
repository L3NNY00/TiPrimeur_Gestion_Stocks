namespace TontonPrimeur
{
    partial class FormFournisseurs
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            id_fournisseur = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Téléphone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Adresse = new DataGridViewTextBoxColumn();
            Modification = new DataGridViewImageColumn();
            Suppression = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(793, 716);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_fournisseur, Nom, Téléphone, Email, Adresse, Modification, Suppression });
            dataGridView1.Location = new Point(261, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(743, 698);
            dataGridView1.TabIndex = 4;
            dataGridView1.Tag = "";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // id_fournisseur
            // 
            id_fournisseur.DataPropertyName = "id_fournisseur";
            id_fournisseur.HeaderText = "ID";
            id_fournisseur.Name = "id_fournisseur";
            id_fournisseur.ReadOnly = true;
            // 
            // Nom
            // 
            Nom.DataPropertyName = "nom";
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            // 
            // Téléphone
            // 
            Téléphone.DataPropertyName = "telephone";
            Téléphone.HeaderText = "Téléphone";
            Téléphone.Name = "Téléphone";
            Téléphone.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Adresse
            // 
            Adresse.DataPropertyName = "adresse";
            Adresse.HeaderText = "Adresse";
            Adresse.Name = "Adresse";
            Adresse.ReadOnly = true;
            // 
            // Modification
            // 
            Modification.HeaderText = "Modification";
            Modification.Image = Properties.Resources.editer;
            Modification.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Modification.Name = "Modification";
            Modification.ReadOnly = true;
            Modification.Resizable = DataGridViewTriState.True;
            Modification.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Suppression
            // 
            Suppression.HeaderText = "Suppression";
            Suppression.Image = Properties.Resources.supprimer;
            Suppression.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Suppression.Name = "Suppression";
            Suppression.ReadOnly = true;
            Suppression.Resizable = DataGridViewTriState.True;
            Suppression.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormFournisseurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 761);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MinimizeBox = false;
            Name = "FormFournisseurs";
            Text = "Fournisseurs";
            WindowState = FormWindowState.Maximized;
            Load += FormFournisseurs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_fournisseur;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Téléphone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Adresse;
        private DataGridViewImageColumn Modification;
        private DataGridViewImageColumn Suppression;
    }
}