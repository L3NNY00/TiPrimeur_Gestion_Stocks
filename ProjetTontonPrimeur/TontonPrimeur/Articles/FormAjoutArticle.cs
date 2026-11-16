using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TontonPrimeur.Connexion;

namespace TontonPrimeur
{
    public partial class FormAjoutArticle : Form
    {
        Database db = new Database();
        string id;
        string mdp;
        public FormAjoutArticle(string idUser, string mdpUser)
        {
            InitializeComponent();
            this.id = idUser;
            this.mdp = mdpUser;
        }

        private void FormAjout_Load(object sender, EventArgs e)
        {
            foreach (DataRow fournisseur in db.requeteBDD(id, mdp, "SELECT nom FROM fournisseur;").Rows)
            {
                comboBox2.Items.AddRange(fournisseur["nom"]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length < 1 || comboBox1.Text.Length < 1 || textBox3.Text.Length < 1 || textBox4.Text.Length < 1 || comboBox2.Text.Length < 1)
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Champ(s) incomplet(s)");
                }
                else
                {
                    string nom = textBox1.Text;
                    string type = comboBox1.Text;

                    float prix_uni = float.Parse(textBox3.Text);
                    NumberFormatInfo formatPoint = new CultureInfo("en-US").NumberFormat; // Récupération du formattage des chiffres de la localité en-US
                    string prix_unitaire = prix_uni.ToString("N2", formatPoint);

                    int quantite_stock = int.Parse(textBox4.Text);
                    DataRow fournisseur = db.requeteBDD(id, mdp, $"SELECT id_fournisseur FROM fournisseur WHERE nom='{comboBox2.Text}';").Rows[0];
                    int id_fournisseur = fournisseur.Field<int>("id_fournisseur");


                    db.requeteBDD(id, mdp, $"INSERT INTO article (nom, type, prix_unitaire, quantite_stock, id_fournisseur) VALUES ('{nom}', '{type}', {prix_unitaire}, {quantite_stock}, {id_fournisseur});");
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
