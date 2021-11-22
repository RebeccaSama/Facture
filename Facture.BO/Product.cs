using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class Product
    {
        public string Num_article { get; set; }
        public object Name { get; set; }
        public string Quantity { get; set; }
        public string Montant_ht { get; set; }

        public Product(string num_article, string name, string quantity, string montant_ht)
        {
            Num_article = num_article;
            Name = name;
            Quantity = quantity;
            Montant_ht = montant_ht;
        }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
