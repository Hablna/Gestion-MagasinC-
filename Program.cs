using TrainingWell;

// Création des produits
Produit p1 = new Produit("Chaussures", 50m, 10);
ProduitElectronique p2 = new ProduitElectronique("Téléphone", 800m, 0, 24);
Produit p3 = new Produit("Sac", 30m, 5);

// Ajout des produits à l’inventaire
Inventaire inventaire = new Inventaire();
inventaire.AjouterProduit(p1);
inventaire.AjouterProduit(p2);
inventaire.AjouterProduit(p3);

// Trier les produits par nom
inventaire.TrierProduitsParNom();
inventaire.AfficherInventaire();

// Rechercher un produit
Produit result = inventaire.RechercherProduitParNom("téléphone");
if (result != null)
    result.AfficherDetails();

// Afficher les produits en rupture de stock
Console.WriteLine ($"les produits en rupture de stock: {inventaire.AfficherProduitsEnRupture()}");

