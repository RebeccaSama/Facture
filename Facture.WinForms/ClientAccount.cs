using System;

namespace Facture.WinForms
{
    public class ClientAccount
    {
        public string Num_article { get; set; }
        public string Designation { get; set; }
        public double Quantity { get; set; }
        public double Montant_ht { get; set; }
        public double Net_à_payer { get; set; }
        public double Total { get; set; }


        public ClientAccount(string num_article, string designation, double quantity, double montant_ht, double net_à_payer,double total)
        {
            Num_article = num_article;
            Designation = designation;
            Quantity = quantity;
            Montant_ht = montant_ht;
            Net_à_payer = net_à_payer;
            Total = total;

        }

        
    }
}
