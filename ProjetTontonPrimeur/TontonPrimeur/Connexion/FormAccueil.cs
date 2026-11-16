using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TontonPrimeur.Connexion;
using TontonPrimeur.Fournisseurs;

namespace TontonPrimeur
{
    public partial class FormAccueil : Form
    {
        Database db = new Database();
        public FormAccueil()
        {
            InitializeComponent();
            boutonValider.Click += boutonValider_Click!;
            this.Text = "Tonton Primeur - Bon retour !";
        }
        Label titreAppli = new Label();
        Label identifiant = new Label();
        TextBox entreeID = new TextBox();
        Label password = new Label();
        TextBox entreePWD = new TextBox();
        Button boutonValider = new Button();
        private void FormAccueil_Load(object sender, EventArgs e)
        {
            try
            {
                imageTiPrimeur.Location = new Point(10, 10);
                imageTiPrimeur.Size = new Size(this.ClientSize.Width / 2 - 20, this.ClientSize.Height - 20);
                this.Controls.Add(imageTiPrimeur);

                titreAppli.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 4);
                identifiant.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 3);
                entreeID.Location = new Point(this.ClientSize.Width / 4 * 3 - entreeID.Width / 2, (this.ClientSize.Height / 3) + (entreeID.Size.Height) * 2);
                password.Location = new Point(this.ClientSize.Width / 2, (this.ClientSize.Height / 5) * 2 + password.Size.Height * 2);
                entreePWD.Location = new Point(this.ClientSize.Width / 4 * 3 - entreePWD.Width / 2, ((this.ClientSize.Height / 5) * 2) + (entreePWD.Size.Height) * 4);
                boutonValider.Location = new Point(this.ClientSize.Width / 4 * 3 - boutonValider.Width / 2, (this.ClientSize.Height / 4) * 2 + boutonValider.Size.Height * 2);
            }
            catch
            {
                titreAppli.Location = new Point(this.ClientSize.Width / 2 - titreAppli.Width / 2, this.ClientSize.Height / 4);
                identifiant.Location = new Point(this.ClientSize.Width / 2 - identifiant.Width / 2, this.ClientSize.Height / 3);
                entreeID.Location = new Point(this.ClientSize.Width / 2 - entreeID.Width / 2, (this.ClientSize.Height / 3) + (entreeID.Size.Height) * 2);
                password.Location = new Point(this.ClientSize.Width / 2 - password.Width / 2, (this.ClientSize.Height / 5) * 2 + password.Size.Height * 2);
                entreePWD.Location = new Point(this.ClientSize.Width / 2 - entreePWD.Width / 2, ((this.ClientSize.Height / 5) * 2) + (entreePWD.Size.Height) * 4);
                boutonValider.Location = new Point(this.ClientSize.Width / 2 - boutonValider.Size.Width / 2, (this.ClientSize.Height / 4) * 2 + boutonValider.Size.Height * 2);
            }

            titreAppli.Text = "Tonton Primeur - Gestion de stock";
            titreAppli.TextAlign = ContentAlignment.MiddleCenter;
            titreAppli.Font = new Font("Segoe", 20);
            titreAppli.Size = new Size(this.ClientSize.Width / 2, 30);
            this.Controls.Add(titreAppli);

            identifiant.Text = "Identifiant";
            identifiant.TextAlign = ContentAlignment.MiddleCenter;
            identifiant.Size = new Size(this.ClientSize.Width / 2, 30);
            this.Controls.Add(identifiant);

            this.Controls.Add(entreeID);

            password.Text = "Mot de passe";
            password.TextAlign = ContentAlignment.MiddleCenter;
            password.Size = new Size(this.ClientSize.Width / 2, 30);
            this.Controls.Add(password);

            entreePWD.UseSystemPasswordChar = true;
            this.Controls.Add(entreePWD);

            boutonValider.Text = "Valider →";
            this.AcceptButton = boutonValider;
            this.Controls.Add(boutonValider);
        }

        private void boutonValider_Click(object sender, EventArgs e)
        {
            string connectionString = $"Server=localhost;Database=stock_fruits_legumes;Uid={entreeID.Text};Pwd={Hashage(entreePWD.Text)};";

            using (var connexion = new MySqlConnection(connectionString))
            {
                try
                {
                    if (entreeID.Text.Length < 1 || entreePWD.Text.Length < 1)
                    {
                        MessageBox.Show("Tous les champs doivent être remplis.", "Champ(s) incomplet(s)");
                    } else
                    {
                        connexion.Open();
                        FormConnexion form = new FormConnexion(entreeID.Text, Hashage(entreePWD.Text));
                        form.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"Identifiant ou mot de passe incorrect.", "Echec de la connexion");
                }
            }
        }

        private string Hashage(string chaine)
        {
            byte[] byteHash;
            using (HashAlgorithm algo = SHA256.Create())
            {
                byteHash = algo.ComputeHash(Encoding.UTF8.GetBytes(chaine));    // Crée une chaîne de bytes à partir du texte saisi.
            }

            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteHash)
            {
                sb.Append(b.ToString("X2"));                                    // Transcris chaque byte en 2 caractères hexadécimaux.
            }

            return sb.ToString();
        }
    }
}
