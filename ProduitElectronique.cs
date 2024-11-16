using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingWell
{
    public class ProduitElectronique : Produit
    {
        public int GarantieEnMois { get; private set; }

        public ProduitElectronique(string nom, decimal prix, int quantitéEnStock, int garantieEnMois)
            : base(nom, prix, quantitéEnStock)
        {
            GarantieEnMois = garantieEnMois;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Garantie en mois: {GarantieEnMois}");
        }

        public override decimal CalculerValeurStock()
        {
            return base.CalculerValeurStock() * 0.9m; // Applique une réduction de 10 %
        }
    }
}
