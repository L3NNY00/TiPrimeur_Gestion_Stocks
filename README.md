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
En outre de la demande initiale, et ayant terminé en avance, je me suis permis de rajouter quelques fonctionnalités. Ces dernières n'étant pas requises dans les consignes, je suis conscient qu'elles soient très largement améliorables.
#### Système d'authentification
J'ai créé un formulaire de connexion au lancement de l'application. Il attend en entrée un nom d'utilisateur et un mot de passe qui correspondent aux identifiants de connexion en base de données.
Pour des raisons évidentes de cybersécurité, 
