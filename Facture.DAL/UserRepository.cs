using System.Collections.Generic;

namespace Facture.DAL
{
    public class UserRepository : BaseRepository<Product>
    {
        List<Product> list { get;set; }
        public UserRepository()
        {
                
        }
        public List<Product> FindByName(string name)
        {
            List<Product> list = new List<Product>();
            foreach (var data in datas)
                if (data.Name.ToString().Contains(name.ToLower()))
                    list.Add(data);

            return new List<Product>(list);
        }
    }

    public class Product
    {
        public object Name { get;  set; }
    }
}
