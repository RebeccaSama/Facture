using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facture.BO;

namespace Facture.BO
{
    public class Facture
    {
        public string Num_article { get; set; }
        public object Name { get; set; }
        public double Quantity { get; set; }
        public Product Product { get; }
        public double Montant_ht { get; set; }
        public string Total { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Facture_num { get; set; }
        public string Date { get; set; }
        public string Total_ht { get; set; }
        public string Net_à_payer { get; set; }

        public Facture(string num_article, object name, double quantity, double montant_ht, string total, string adresse, string tel, string facture_num, string date, string total_ht, string net_à_payer)
        {
            Num_article = num_article;
            Name = name;
            Quantity = quantity;
            Montant_ht = montant_ht;
            Adresse = adresse;
            Tel = tel;
            Facture_num = facture_num;
            Date = date;
            Total_ht = total_ht;
            Net_à_payer = net_à_payer;
        }
       /* public Facture(Product product, double quantite=1)
        {
            Product = product;
            Montant_ht = product.Montant_ht;
            Name = product.Name;
            if (product.Quantity < quantite)
            {
                quantite = product.Quantity;
            }
            ChangeQuantity(quantite);
        }
        public Facture ChangeQuantity(double quantity)
        {
            Quantity = quantity;
            Total_ht = GetTotal_ht() + "F";
            return this;
        }
        public double GetTotal_ht()
        {
            return Product.Montant_ht * Quantity;
        }*/
    }
}
