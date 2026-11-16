using TontonPrimeur.Connexion;

namespace TontonPrimeur
{
    public partial class FormConnexion : Form
    {
        string id;
        string mdp;
        public FormConnexion(string idUser, string mdpUser)
        {
            InitializeComponent();
            FormClosing += FermetureAppli!;
            id = idUser;
            mdp = mdpUser;
            this.Text = "Tonton Primeur - Accueil";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats(id, mdp);
            formStats.MdiParent = this;
            formStats.Show();
        }

        private void fournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFournisseurs formFournisseurs = new FormFournisseurs(id, mdp);
            formFournisseurs.MdiParent = this;
            formFournisseurs.Show();
        }
        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArticles formArticles = new FormArticles(id, mdp);
            formArticles.MdiParent = this;
            formArticles.Show();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats(id, mdp);
            formStats.MdiParent = this;
            formStats.Show();
        }

        private void FermetureAppli(object sender, FormClosingEventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment quitter ?", "Fermeture", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                if (Application.OpenForms.Count > 0)
                {
                    Application.OpenForms[0]!.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
