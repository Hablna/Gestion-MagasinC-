using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingWell
{
    internal class Inventaire
    {
        private List<Produit> ListeProduits;
        //constructeur
        public Inventaire()
        {
            ListeProduits = new List<Produit>();
        }

        public void AjouterProduit(Produit produit)
        {
            //ajout du produit dans la liste
            ListeProduits.Add(produit);
        }
        public void AfficherInventaire()
        {
            foreach (Produit produit in ListeProduits)
            {
                Console.WriteLine($"Nom: {produit.Nom}, prix: {produit.Prix}, stock: {produit.QuantitéEnStock}");
                Console.WriteLine();
            }
        }

        public decimal CalculerValeurTotale()
        {
            decimal valeurTotale = 0;
            foreach (Produit produit in ListeProduits)
            {
                valeurTotale += produit.CalculerValeurStock();
            }
            return valeurTotale;
        }
     

        public void ExpédierProduit(string nomProduit, int quantité)
        {
            foreach (Produit produit in ListeProduits)
            {
                //recherche du produit dans la liste en faisant un strip sur le nom

                if (produit.Nom.Trim() == nomProduit.Trim() && quantité < produit.QuantitéEnStock)
                {
                    produit.Expédier(quantité);
                    return;
                }
                else
                {
                    Console.WriteLine("Produit non trouvé ou quantité insuffisante");
                }
            }
        }
        //trie les produits par nom
        public void TrierProduitsParNom()
        {
            ListeProduits.Sort(
                (produit1, produit2) => string.Compare(produit1.Nom, produit2.Nom, StringComparison.OrdinalIgnoreCase)
            );
        }
        public string AfficherProduitsEnRupture()
        {
            //declarer un tableau de string
            List<string>StockVide = new List<string>();

            foreach (Produit produit in ListeProduits)
            {
                if (produit.QuantitéEnStock == 0)
                {
                    StockVide.Add(produit.Nom);
                }
            }
            return string.Join(",", StockVide);
        }
        public Produit RechercherProduitParNom(string nomProduit)
        {
            var MotTrouve = ListeProduits.FirstOrDefault(produit => produit.Nom.ToLower() == nomProduit.ToLower());
            if (MotTrouve != null)
            {
                return MotTrouve;
            }
            else
            {
                //message d'erreur
                Console.WriteLine("Produit non trouvé");
                return null;
            }
        }
    }

}
