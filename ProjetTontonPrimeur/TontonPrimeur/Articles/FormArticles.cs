using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TontonPrimeur.Articles;
using TontonPrimeur.Connexion;
using TontonPrimeur.Fournisseurs;

namespace TontonPrimeur
{
    public partial class FormArticles : Form
    {
        Database db = new Database();
        string id;
        string mdp;
        string affichage = "SELECT article.id_article, article.nom, article.type, article.prix_unitaire, article.quantite_stock, fournisseur.nom AS fournisseur FROM article INNER JOIN fournisseur ON article.id_fournisseur = fournisseur.id_fournisseur;";
        Label titre = new Label();
        public FormArticles(string idUser, string mdpUser)
        {
            InitializeComponent();
            this.id = idUser;
            this.mdp = mdpUser;
        }

        private void FormArticles_Load(object sender, EventArgs e)
        {
            titre.Text = "Articles en stock";
            titre.ForeColor = Color.SteelBlue;
            titre.Font = new Font("Segoe", 20);
            titre.Size = new Size(300, 30);
            titre.TextAlign = ContentAlignment.MiddleCenter;
            titre.Location = new Point(this.ClientSize.Width / 2 - titre.Width / 2, 10);
            dataGridView1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - button1.Height - titre.Height - 50);
            dataGridView1.Location = new Point(this.ClientSize.Width / 2 - dataGridView1.Size.Width / 2, titre.Bottom + 20);
            button1.Location = new Point(this.ClientSize.Width / 2 + dataGridView1.Size.Width / 2 - button1.Size.Width, this.ClientSize.Height - 10 - button1.Height);
            this.Controls.Add(titre);

            dataGridView1.DataSource = db.requeteBDD(id, mdp, affichage);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Padding = new Padding(2, 2, 2, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAjoutArticle formAjout = new FormAjoutArticle(id, mdp);
            formAjout.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var confirmSuppr = MessageBox.Show($"Voulez-vous vraiment supprimer les stocks de {dataGridView1["Nom", e.RowIndex].Value} ?", "Suppression article(s)", MessageBoxButtons.YesNo);
                if (confirmSuppr == DialogResult.Yes)
                {
                    db.requeteBDD(id, mdp, $"DELETE FROM article WHERE id_article={dataGridView1["ID", e.RowIndex].Value};");
                    FormArticles_Load(sender, e);
                }
            }

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                FormModifArticle formModifArticle = new FormModifArticle(id, mdp, dataGridView1["Nom", e.RowIndex].Value!.ToString() ?? "", dataGridView1["Type", e.RowIndex].Value!.ToString() ?? "", dataGridView1["Prix", e.RowIndex].Value!.ToString() ?? "", dataGridView1["Quantité", e.RowIndex].Value!.ToString() ?? "", dataGridView1["Fournisseur", e.RowIndex].Value!.ToString() ?? "", dataGridView1["id_article", e.RowIndex].Value!.ToString() ?? "");
                formModifArticle.Show();
            }
        }
    }
}
