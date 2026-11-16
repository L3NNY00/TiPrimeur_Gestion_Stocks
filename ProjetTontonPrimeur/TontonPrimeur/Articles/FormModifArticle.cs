using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TontonPrimeur.Connexion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TontonPrimeur.Articles
{
    public partial class FormModifArticle : Form
    {
        Database db = new Database();
        string id;
        string mdp;
        string idArticle;
        string preNom;
        string preType;
        string prePrix;
        string preQte;
        string preFournisseur;
        public FormModifArticle(string idUser, string mdpUser, string prevNom, string prevType, string prevPrix, string prevQte, string prevFournisseur, string prevId)
        {
            InitializeComponent();
            this.id = idUser;
            this.mdp = mdpUser;
            preNom = prevNom;
            preType = prevType;
            prePrix = prevPrix;
            preQte = prevQte;
            preFournisseur = prevFournisseur;
            idArticle = prevId;
            this.Text = "Mofifier un article";
        }

        private void FormModifArticle_Load(object sender, EventArgs e)
        {
            List<string> listeFournisseurs = new List<string>();

            foreach (DataRow fournisseur in db.requeteBDD(id, mdp, "SELECT nom FROM fournisseur;").Rows)
            {
                comboBox2.Items.AddRange(fournisseur["nom"]);
            }

            textBox1.Text = preNom;
            comboBox1.Text = preType;
            textBox3.Text = prePrix;
            numericUpDown1.Text = preQte;
            comboBox2.Text = preFournisseur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nvNom = textBox1.Text;
                string nvType = comboBox1.Text;

                float prix_uni = float.Parse(textBox3.Text);
                NumberFormatInfo formatPoint = new CultureInfo("en-US").NumberFormat; // Récupération du formattage des chiffres de la localité en-US
                string nvPrix = prix_uni.ToString("N2", formatPoint);

                int nvQte = int.Parse(numericUpDown1.Text);

                DataRow fournisseur = db.requeteBDD(id, mdp, $"SELECT id_fournisseur FROM fournisseur WHERE nom='{comboBox2.Text}';").Rows[0];
                int nvFournisseur = fournisseur.Field<int>("id_fournisseur");

                db.requeteBDD(id, mdp, $"UPDATE article SET nom='{nvNom}', type='{nvType}', prix_unitaire='{nvPrix}', quantite_stock='{nvQte}', id_fournisseur='{nvFournisseur}' WHERE id_article={idArticle};");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
