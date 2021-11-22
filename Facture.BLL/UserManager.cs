using System.Collections.Generic;
using Facture.DAL;
using System;

namespace Facture.BLL
{
    public class UserManager
    {
        private BaseRepository<Product> userRepository;
        public UserManager()
        {
            userRepository = new UserRepository();
        }
        public void Add(Product product)
        {
            userRepository.Add(product);
        }
        public void Edit(Product OldProduct, Product product)
        {
            userRepository.Set(OldProduct, product);
        }
        public void Delete(Product product)
        {
            userRepository.Delete(product);
        }
        public List<Product> GetAllUserRepository()
        {
            return userRepository.GetAll();
        }

        
    }
}
