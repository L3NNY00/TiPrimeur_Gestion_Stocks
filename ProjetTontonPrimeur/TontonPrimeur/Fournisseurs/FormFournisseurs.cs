using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TontonPrimeur.Connexion;
using TontonPrimeur.Fournisseurs;

namespace TontonPrimeur
{
    public partial class FormFournisseurs : Form
    {
        Database db = new Database();
        string id;
        string mdp;
        string affichage = "SELECT * FROM fournisseur;";
        Label titre = new Label();
        public FormFournisseurs(string idUser, string mdpUser)
        {
            InitializeComponent();
            this.id = idUser;
            this.mdp = mdpUser;
        }

        private void FormFournisseurs_Load(object sender, EventArgs e)
        {
            titre.Text = "Liste des fournisseurs";
            titre.ForeColor = Color.ForestGreen;
            titre.Font = new Font("Segoe", 20);
            titre.Size = new Size(600, 30);
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
            FormAjoutFourn formAjoutFourn = new FormAjoutFourn(id, mdp);
            formAjoutFourn.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var confirmSuppr = MessageBox.Show($"Voulez-vous vraiment supprimer le fournisseur {dataGridView1["Nom", e.RowIndex].Value} ?", "Suppression fournisseur", MessageBoxButtons.YesNo);
                if (confirmSuppr == DialogResult.Yes)
                {
                    db.requeteBDD(id, mdp, $"DELETE FROM fournisseur WHERE id_fournisseur={dataGridView1["ID", e.RowIndex].Value};");
                    FormFournisseurs_Load(sender, e);
                }
            }

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                FormModifFourn formModifFourn = new FormModifFourn(id, mdp, dataGridView1["Nom", e.RowIndex].Value!.ToString() ?? "", dataGridView1["Téléphone", e.RowIndex].Value!.ToString() ?? "", dataGridView1["Email", e.RowIndex].Value!.ToString() ?? "", dataGridView1["Adresse", e.RowIndex].Value!.ToString() ?? "", dataGridView1["id_fournisseur", e.RowIndex].Value!.ToString() ?? "");
                formModifFourn.Show();
            }
        }
    }
}
