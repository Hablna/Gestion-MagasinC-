using TrainingWell;

// Création de produits
Produit produit1 = new Produit("Chaussures", 50.0m, 20);
ProduitElectronique produit2 = new ProduitElectronique("Téléphone", 800.0m, 5, 24);

// Création de l'inventaire
Inventaire inventaire = new Inventaire();
inventaire.AjouterProduit(produit1);
inventaire.AjouterProduit(produit2);

// Affichage de l'inventaire
inventaire.AfficherInventaire();

// Calcul de la valeur totale
Console.WriteLine($"Valeur totale de l'inventaire : {inventaire.CalculerValeurTotale()}");

// Expédition d'un produit
inventaire.ExpédierProduit("Téléphone", 2);
