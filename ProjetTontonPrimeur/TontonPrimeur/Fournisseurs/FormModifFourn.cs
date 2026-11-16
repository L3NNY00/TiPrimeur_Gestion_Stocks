using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TontonPrimeur.Connexion;

namespace TontonPrimeur.Fournisseurs
{
    public partial class FormModifFourn : Form
    {
        Database db = new Database();
        string id;
        string mdp;
        string idFourn;
        string preNom;
        string preTelephone;
        string preEmail;
        string preAdresse;
        public FormModifFourn(string idUser, string mdpUser, string prevNom, string prevTelephone, string prevEmail, string prevAdresse, string prevId)
        {
            InitializeComponent();
            this.id = idUser;
            this.mdp = mdpUser;
            preNom = prevNom;
            preTelephone = prevTelephone;
            preEmail = prevEmail;
            preAdresse = prevAdresse;
            idFourn = prevId;
            this.Text = "Modifier un fournisseur";
        }

        private void FormModifFourn_Load(object sender, EventArgs e)
        {
            textBox1.Text = preNom;
            textBox2.Text = preTelephone;
            textBox3.Text = preEmail;
            textBox4.Text = preAdresse;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nvNom = textBox1.Text;
                string nvTelephone = textBox2.Text;
                string nvEmail = textBox3.Text;
                string nvAdresse = textBox4.Text;

                db.requeteBDD(id, mdp, $"UPDATE fournisseur SET nom='{nvNom}', telephone='{nvTelephone}', email='{nvEmail}', adresse='{nvAdresse}' WHERE id_fournisseur={idFourn};");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
