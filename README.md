# TontonPrimeur - Application de gestion de stocks en C#

## Contexte initial
> L’entreprise Ti’Primeur est spécialisée dans la vente de fruits et légumes.  
> Actuellement, les stocks sont suivis manuellement. Le responsable souhaite disposer d’une
> petite application permettant de gérer les différents articles proposés à la vente ainsi que
> leurs fournisseurs.  
> Votre mission consiste à développer une application de bureau en C# avec Windows
> Forms permettant de gérer ces informations.  
> L’application sera reliée à une base de données MySQL / MariaDB.

## Technologies
TontonPrimeur est développé sur le framework Windows Forms et utilise donc les composants de base de l'environnement de développement.  
Pour les fonctionnalités plus avancées, il fait appel à des bibliothèques externes comme Data.Visualization pour le système de supervision et MySQLConnector pour la liaison à la base de données.  
Ainsi, l'application est codée en C# et utilise une base de données MariaDB. J'ai fait le choix de ne pas faire appel à des outils externes pour le développement du logiciel, quels qu'ils soient.

## Fonctionnalités
### Obligatoires
L'application permet par défaut :
- La visualisation, l'ajout, la modification et la suppression des articles et des fournisseurs liés à l'entreprise, dans leur onglet dédié ;
- Le tri des articles et fournisseurs dans leur tableau respectif par ordre croissant et décroissant ;
- La connexion à la base de données, avec changements effectifs (requêtes).

### Supplémentaires
En outre de la demande initiale, et ayant terminé en avance, je me suis permis de rajouter quelques fonctionnalités. Ces dernières n'étant pas requises dans les consignes, je suis conscient qu'elles puissent être largement améliorables.
#### Système d'authentification
J'ai créé un formulaire de connexion au lancement de l'application. Il attend en entrée un nom d'utilisateur et un mot de passe qui correspondent aux identifiants de connexion en base de données.  
Pour des raisons évidentes de cybersécurité, le mot de passe est chiffré avec une fonction personnalisée qui se base sur l'algorithme SHA-256.  
Le responsable de l'entreprise étant le seul utilisateur ayant accès à l'application, j'ai jugé cette méthode convenable dans la mesure où la création de nombreux comptes en base de données n'est pas nécessaire, ce qui représente un gain de temps et de sécurité (le Système de Gestion de Base de Données Relationnelles rajoute une couche de sécurité avec un chiffrement des mots de passe par défaut).
#### Espace de supervision
Au lancement de l'application, au lieu d'avoir un accès direct aux tableaux de données, l'utilisateur est dirigé vers un espace de supervision, d'accueil comprenant des statistiques et des graphiques de synthèse. Cela permet donc au responsable d'avoir une vue d'ensemble sur l'état de ses stocks.
#### Aspect responsive
L'application est théoriquement entièrement adaptable à tous types de supports et le placement des composants étant pour la plupart calculé automatiquement, aucun problème de lisibilité ne devrait survenir.

## Accès et déploiement
### Authentification
Par défaut, le responsable peut accéder aux fonctionnalités de l'application grâce aux identifiants de connexion suivants :
- Identifiant : `tontonPrimeuw` ;
- Mot de passe : `caribouw`.  

N'étant pas des chaînes très complexes ni professionnelles, il suffit de modifier le mot de passe par lequel est identifié l'utilisateur SQL dans la section correspondante du fichier `stock_fruits_legumes.sql` pour garantir une meilleure sécurité. Cependant, ce dernier est d'ores et déjà chiffré par l'algorithme personnalisé, il faut donc chiffrer par avance le nouveau mot de passe pour que la connexion soit fructueuse.
### Mise en place
Le fichier `stock_fruits_legumes.sql` est configuré de telle sorte à pouvoir avoir une base de données opérationnelle d'un simple copier-coller de l'intégralité de son contenu.  
Sont contenus dans ce dernier :
- Création de la base ;
- Création des tables _fournisseur_ et _article_ ;
- Insertion de données de test (fournisseurs et articles) ;
- Requêtes de test pour afficher le contenu des tables en cas de réussite ;
- Création de l'utilisateur unique authentifiable.

Enfin, l'intégralité du code source de l'application est située dans le répertoire `ProjetTontonPrimeur`, solution comprise. Des modifications peuvent être à effectuer sur les fichiers de configuration du projet.
