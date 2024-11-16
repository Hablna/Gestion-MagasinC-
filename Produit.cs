using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingWell
{
    public class Produit : IExpediable
    {
        public string Nom { get; private set; }
        public decimal Prix { get; private set; }
        public int QuantitéEnStock { get; private set; }

        public Produit(string nom, decimal prix, int quantitéEnStock)
        {
            Nom = nom;
            Prix = prix;
            QuantitéEnStock = quantitéEnStock;
        }
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"nom: {Nom} \nPrix: {Prix} \nQuantité en stock: {QuantitéEnStock}");
        }

        public void ReduireStock(int quantité)
        {
            if (!(quantité > QuantitéEnStock))
            {
                QuantitéEnStock -= quantité;
            }
            else
            {
                throw new InvalidOperationException("Quantité en stock insuffisante");
            }
        }

        public virtual decimal CalculerValeurStock() => Prix * QuantitéEnStock;

        public void Expédier(int quantité)
        {
            try
            {
                ReduireStock(quantité);
                Console.WriteLine($"Expedition de {quantité} effectuer avec succès");

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
