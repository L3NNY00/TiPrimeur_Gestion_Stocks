using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TontonPrimeur.Connexion;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TontonPrimeur.Connexion
{
    public partial class FormStats : Form
    {
        Database db = new Database();
        string id;
        string mdp;
        Label titreDashboard = new Label();
        GroupBox nbArticles = new GroupBox();
        Label statArticles = new Label();
        Label labelNbArticles = new Label();
        PictureBox iconeArticle = new PictureBox();
        GroupBox nbFourn = new GroupBox();
        Label statFourn = new Label();
        Label labelNbFourn = new Label();
        PictureBox iconeFourn = new PictureBox();
        GroupBox totalStock = new GroupBox();
        Label statStocks = new Label();
        Label labelTotalStock = new Label();
        PictureBox iconeStock = new PictureBox();
        Chart graphiqueRessources = new Chart();
        Chart graphiqueStocks = new Chart();
        Label navigation = new Label();
        public FormStats(string idUser, string mdpUser)
        {
            InitializeComponent();
            this.id = idUser;
            this.mdp = mdpUser;
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            titreDashboard.Text = "Tonton Primeur - Vue d'ensemble";
            titreDashboard.TextAlign = ContentAlignment.TopLeft;
            titreDashboard.Font = new Font("Segoe", 20);
            titreDashboard.Size = new Size(500, 30);

            // GRAPHIQUE
            graphiqueRessources.Series.Clear();
            Series nbProduits = new Series("Nombre de produits");
            Series nbFournisseur = new Series("Nombre de fournisseurs");
            ChartArea area = new ChartArea("main");
            Legend legende = new Legend("legende");
            legende.Alignment = StringAlignment.Center;
            legende.Font = new Font("Segoe", 12);
            graphiqueRessources.Legends.Add(legende);
            graphiqueRessources.ChartAreas.Add(area);
            nbProduits.ChartArea = "main";
            nbProduits.ChartType = SeriesChartType.Pie;
            nbProduits.Color = Color.SteelBlue;
            nbProduits.BorderWidth = 5;
            nbProduits.Legend = "legende";
            nbProduits.Label = "#VALX (#VAL)";
            nbProduits.LegendText = "#VALX";
            //nbFournisseur.ChartArea = "main";
            //nbFournisseur.ChartType = SeriesChartType.Pie;
            //nbFournisseur.Color = Color.ForestGreen;
            //nbFournisseur.BorderWidth = 2;

            graphiqueStocks.Series.Clear();
            Series qteStocks = new Series("Produits en stock");
            ChartArea area1 = new ChartArea("main1");
            graphiqueStocks.ChartAreas.Add(area1);
            qteStocks.ChartArea = "main1";
            qteStocks.ChartType = SeriesChartType.Column;
            qteStocks.Color = Color.Peru;
            qteStocks.BorderWidth = 2;


            // 2. NOMBRE FOURNISSEURS
            nbFourn.ForeColor = Color.ForestGreen;
            nbFourn.FlatStyle = FlatStyle.Flat;
            nbFourn.Text = "Nombre de fournisseurs";
            Int64 nbFournisseurs = 0;
            try
            {
                DataRow fournisseur = db.requeteBDD(id, mdp, $"SELECT COUNT(*) as nbFournisseur FROM fournisseur;").Rows[0];
                nbFournisseurs = fournisseur.Field<Int64>("nbFournisseur");
                statFourn.Text = nbFournisseurs.ToString();
                nbProduits.Points.AddXY("Nombre fournisseurs", nbFournisseurs);
                nbProduits.Points[0].Color = Color.ForestGreen;
            } catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des données.", "Connexion impossible");
            }
            statFourn.Font = new Font("Segoe", 20);
            statFourn.AutoSize = true;
            statFourn.Location = new Point(10, nbFourn.Height / 4);
            labelNbFourn.Text = "Fournisseurs affiliés";
            labelNbFourn.Font = new Font("Segoe", 15);
            labelNbFourn.AutoSize = true;
            labelNbFourn.Location = new Point(10, statFourn.Bottom + 10);
            nbFourn.Controls.Add(statFourn);
            nbFourn.Controls.Add(labelNbFourn);
            nbFourn.Controls.Add(iconeArticle);
            nbFourn.Width = (this.ClientSize.Width / 3) - 60;
            nbFourn.Location = new Point(this.ClientSize.Width / 2 - nbFourn.Width / 2, this.ClientSize.Height / 4 - nbFourn.Height);
            this.Controls.Add(nbFourn);

            // 1. NOMBRE PRODUITS
            nbArticles.ForeColor = Color.SteelBlue;
            nbArticles.FlatStyle = FlatStyle.Flat;
            nbArticles.Text = "Nombre de produits";
            Int64 nbArticle = 0;
            try
            {
                DataRow articles = db.requeteBDD(id, mdp, $"SELECT COUNT(*) as nbArticles FROM article;").Rows[0];
                nbArticle = articles.Field<Int64>("nbArticles");
                statArticles.Text = nbArticle.ToString();
                nbProduits.Points.AddXY("Nombre produits", nbArticle);
                nbProduits.Points[1].Color = Color.SteelBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des données.", "Connexion impossible");
            }
            statArticles.Font = new Font("Segoe", 20);
            statArticles.AutoSize = true;
            statArticles.Location = new Point(10, nbArticles.Height / 4);
            labelNbArticles.Text = "Produits différents en vente";
            labelNbArticles.Font = new Font("Segoe", 15);
            labelNbArticles.AutoSize = true;
            labelNbArticles.Location = new Point(10, statArticles.Bottom + 10);
            nbArticles.Controls.Add(statArticles);
            nbArticles.Controls.Add(labelNbArticles);
            nbArticles.Controls.Add(iconeArticle);
            nbArticles.Width = (this.ClientSize.Width / 3) - 60;
            nbArticles.Location = new Point(nbFourn.Left - 10 - nbArticles.Width, this.ClientSize.Height / 4 - nbFourn.Height);
            this.Controls.Add(nbArticles);

            // 3. PRODUITS EN STOCK
            totalStock.ForeColor = Color.Peru;
            totalStock.FlatStyle = FlatStyle.Flat;
            totalStock.Text = "Nombre de produits stockés";
            decimal totStock = 0;
            try
            {
                DataRow stocks = db.requeteBDD(id, mdp, $"SELECT SUM(quantite_stock) as stocks FROM article;").Rows[0];
                totStock = stocks.Field<decimal>("stocks");
                statStocks.Text = totStock.ToString();
                qteStocks.Points.AddXY("Produits en stock", totStock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupération des données.", "Connexion impossible");
            }
            statStocks.Font = new Font("Segoe", 20);
            statStocks.AutoSize = true;
            statStocks.Location = new Point(10, totalStock.Height / 4);
            labelTotalStock.Text = "Produits en stock";
            labelTotalStock.Font = new Font("Segoe", 15);
            labelTotalStock.AutoSize = true;
            labelTotalStock.Location = new Point(10, statStocks.Bottom + 10);
            totalStock.Controls.Add(statStocks);
            totalStock.Controls.Add(labelTotalStock);
            totalStock.Controls.Add(iconeArticle);
            totalStock.Width = (this.ClientSize.Width / 3) - 60;
            totalStock.Location = new Point(nbFourn.Right + 10, this.ClientSize.Height / 4 - nbFourn.Height);
            this.Controls.Add(totalStock);

            graphiqueRessources.Series.Add(nbProduits);
            //graphiqueRessources.Series.Add(nbFournisseur);
            graphiqueRessources.Titles.Add("Produits et fournisseurs");
            graphiqueRessources.Titles[0].Font = new Font("Segoe", 16);
            graphiqueRessources.Size = new Size(graphiqueRessources.Width * 2, graphiqueRessources.Height);
            graphiqueRessources.Location = new Point(this.ClientSize.Width / 4 - graphiqueRessources.Width / 2, this.ClientSize.Height / 2 - graphiqueRessources.Height / 2);
            graphiqueStocks.Series.Add(qteStocks);
            graphiqueStocks.Titles.Add("Quantité de stocks");
            graphiqueStocks.Titles[0].Font = new Font("Segoe", 16);
            graphiqueStocks.Size = new Size(graphiqueStocks.Width * 2, graphiqueStocks.Height);
            graphiqueStocks.Location = new Point((this.ClientSize.Width / 4) * 3 - graphiqueStocks.Width / 2, this.ClientSize.Height / 2 - graphiqueRessources.Height / 2);
            this.Controls.Add(graphiqueRessources);
            this.Controls.Add(graphiqueStocks);

            titreDashboard.Location = new Point(this.ClientSize.Width / 2 - titreDashboard.Width / 2, nbArticles.Top - nbArticles.Height);
            this.Controls.Add(titreDashboard);

            navigation.Text = "Pour afficher les stocks et partenaires :\nAffichage > Articles / Fournisseurs.";
            navigation.Size = new Size(600, 50);
            navigation.Font = new Font("Segoe", 15);
            navigation.Location = new Point(this.ClientSize.Width / 2 - navigation.Width / 2, this.ClientSize.Height / 4 * 3);
            navigation.TextAlign = ContentAlignment.MiddleCenter;
            navigation.BackColor = Color.DarkGray;
            this.Controls.Add(navigation);
        }
    }
}
