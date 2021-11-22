namespace Facture.WinForms
{
    public class Identification
    {
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Facture_num { get; set; }
        public string Date { get; set; }
        public byte[] Logo { get; set; }

        public Identification(string name, string adresse, string tel,string facture_num, string date,byte[] logo)
        {
            Name = name;
            Adresse = adresse;
            Tel = tel;
            Facture_num = facture_num;
            Date = date;
            Logo = logo;
        }
    }
}
