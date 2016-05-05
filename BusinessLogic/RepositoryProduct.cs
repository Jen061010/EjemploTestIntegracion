using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RepositoryProduct:RepositoryBase<Product>,IRepositoryProduct
    {
        
        public RepositoryProduct(IContextBase ctx)
            :base(ctx)
        {
            
        }
        
        public IEnumerable<Product> GetAll()
        {
            return Entity.Select(c => c);

        }
        public Product Add(Product product) 
        {
            Entity.Add(product);
            return product;
        }
        public void Delete(Product product) 
        {
            
            Entity.Remove(product);
        }
        public Product Get(int id) 
        {
            return Entity.Where(c => c.Id == id).FirstOrDefault();
        }
        public void Update(Product product) 
        {
            Modify(product);
        }

    }
}
