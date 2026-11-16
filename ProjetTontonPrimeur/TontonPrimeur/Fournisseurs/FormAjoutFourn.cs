using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TontonPrimeur.Connexion;

namespace TontonPrimeur.Fournisseurs
{
    
    public partial class FormAjoutFourn : Form
    {
        Database db = new Database();
        string id;
        string mdp;
        public FormAjoutFourn(string idUser, string mdpUser)
        {
            InitializeComponent();
            this.id = idUser;
            this.mdp = mdpUser;
            this.Text = "Ajouter un fournisseur";
        }

        private void FormAjoutFourn_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = textBox1.Text;
                string telephone = textBox2.Text;
                string email = textBox3.Text;
                string adresse = textBox4.Text;

                if (nom.Length < 1 || telephone.Length < 1 || email.Length < 1 || adresse.Length < 1)
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Champ(s) incomplet(s)");
                } else
                {
                    db.requeteBDD(id, mdp, $"INSERT INTO fournisseur (nom, telephone, email, adresse) VALUES ('{nom}', '{telephone}', '{email}', '{adresse}');");
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
