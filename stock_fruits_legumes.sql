-- ============================================================
-- Base de donnees : stock_fruits_legumes
-- Projet : Ti'Primeur - C# WinForms + MySQL/MariaDB
-- ============================================================

DROP DATABASE IF EXISTS stock_fruits_legumes;

CREATE DATABASE stock_fruits_legumes
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_general_ci;

USE stock_fruits_legumes;

-- ============================================================
-- TABLE : fournisseur
-- ============================================================

CREATE TABLE fournisseur (
    id_fournisseur INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(100) NOT NULL,
    telephone VARCHAR(20),
    email VARCHAR(100),
    adresse VARCHAR(255)
);

-- ============================================================
-- TABLE : article
-- ============================================================

CREATE TABLE article (
    id_article INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(100) NOT NULL,
    type VARCHAR(20) NOT NULL,
    prix_unitaire DECIMAL(6,2) NOT NULL,
    quantite_stock INT NOT NULL,
    id_fournisseur INT NOT NULL,
    CONSTRAINT fk_article_fournisseur
        FOREIGN KEY (id_fournisseur)
        REFERENCES fournisseur(id_fournisseur)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

-- ============================================================
-- DONNeES DE TEST : fournisseurs
-- ============================================================

INSERT INTO fournisseur (nom, telephone, email, adresse) VALUES
('Tropic Frais', '0590 11 22 33', 'contact@tropicfrais.fr', 'Basse-Terre'),
('Jardin Creole', '0590 44 55 66', 'contact@jardincreole.fr', 'Gourbeyre'),
('Veggie Caraibes', '0590 77 88 99', 'contact@veggiecaraibes.fr', 'Pointe-a-Pitre'),
('Saveurs des Iles', '0590 12 34 56', 'contact@saveursdesiles.fr', 'Les Abymes');

-- ============================================================
-- DONNeES DE TEST : articles
-- ============================================================

ALTER TABLE article AUTO_INCREMENT=0;
INSERT INTO article
(nom, type, prix_unitaire, quantite_stock, id_fournisseur)
VALUES
('Ananas Victoria', 'Fruit', 3.20, 60, 1),
('Banane plantain', 'Fruit', 2.50, 120, 1),
('Mangue Julie', 'Fruit', 2.00, 100, 3),
('Maracudja', 'Fruit', 2.80, 45, 4),
('Tomate pays', 'Legume', 1.80, 80, 2),
('Christophine', 'Legume', 1.50, 50, 2),
('Concombre', 'Legume', 1.20, 35, 3),
('Aubergine', 'Legume', 2.10, 40, 4);

-- ============================================================
-- REQUÊTES UTILES POUR TESTER LA BASE
-- ============================================================

SELECT * FROM fournisseur;

SELECT * FROM article;

SELECT
    article.id_article,
    article.nom,
    article.type,
    article.prix_unitaire,
    article.quantite_stock,
    fournisseur.nom AS fournisseur
FROM article
INNER JOIN fournisseur
    ON article.id_fournisseur = fournisseur.id_fournisseur;

SELECT *
FROM article
ORDER BY nom ASC;

SELECT *
FROM article
ORDER BY nom DESC;

-- ============================================================
-- GESTION DE LA CONNEXION
-- ============================================================

CREATE TABLE meta (id varchar(100), mdp varchar(100));
USE mysql;
DROP USER IF EXISTS 'tontonPrimeuw'@'localhost';
CREATE USER 'tontonPrimeuw'@'localhost' IDENTIFIED BY '14277BEE8D5FAC09DD2A66AE0E59F46C76E3D6EADCC2F047884B7EC061524690';
SELECT User, Host, Password FROM user;
GRANT SELECT, INSERT, UPDATE, DELETE ON stock_fruits_legumes.article TO 'tontonPrimeuw'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON stock_fruits_legumes.fournisseur TO 'tontonPrimeuw'@'localhost';

USE stock_fruits_legumes;
