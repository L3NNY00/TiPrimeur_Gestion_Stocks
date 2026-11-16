namespace TontonPrimeur
{
    partial class FormArticles
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticles));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            id_article = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Prix = new DataGridViewTextBoxColumn();
            Quantité = new DataGridViewTextBoxColumn();
            Fournisseur = new DataGridViewTextBoxColumn();
            Modification = new DataGridViewImageColumn();
            Suppression = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_article, Nom, Type, Prix, Quantité, Fournisseur, Modification, Suppression });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(844, 698);
            dataGridView1.TabIndex = 2;
            dataGridView1.Tag = "";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(781, 716);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // id_article
            // 
            id_article.DataPropertyName = "id_article";
            id_article.HeaderText = "ID";
            id_article.Name = "id_article";
            id_article.ReadOnly = true;
            // 
            // Nom
            // 
            Nom.DataPropertyName = "nom";
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            // 
            // Type
            // 
            Type.DataPropertyName = "type";
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Prix
            // 
            Prix.DataPropertyName = "prix_unitaire";
            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            Prix.ReadOnly = true;
            // 
            // Quantité
            // 
            Quantité.DataPropertyName = "quantite_stock";
            Quantité.HeaderText = "Quantité";
            Quantité.Name = "Quantité";
            Quantité.ReadOnly = true;
            // 
            // Fournisseur
            // 
            Fournisseur.DataPropertyName = "fournisseur";
            Fournisseur.HeaderText = "Fournisseur";
            Fournisseur.Name = "Fournisseur";
            Fournisseur.ReadOnly = true;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = resources.GetObject("dataGridViewCellStyle1.NullValue");
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            Suppression.DefaultCellStyle = dataGridViewCellStyle1;
            Suppression.HeaderText = "Suppression";
            Suppression.Image = Properties.Resources.supprimer;
            Suppression.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Suppression.Name = "Suppression";
            Suppression.ReadOnly = true;
            Suppression.Resizable = DataGridViewTriState.True;
            Suppression.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormArticles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 751);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            MinimizeBox = false;
            Name = "FormArticles";
            Text = "Articles";
            WindowState = FormWindowState.Maximized;
            Load += FormArticles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn id_article;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Prix;
        private DataGridViewTextBoxColumn Quantité;
        private DataGridViewTextBoxColumn Fournisseur;
        private DataGridViewImageColumn Modification;
        private DataGridViewImageColumn Suppression;
    }
}