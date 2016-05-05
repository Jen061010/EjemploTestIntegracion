using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositoryProduct
    {
        
        IEnumerable<Product> GetAll();
        Product Add(Product product);
        Product Get(int id);
        void Delete(Product product);
        void Update(Product product);

        
    }
}
