using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RepositoryBase<T> where T:class
    {
        readonly IContextBase _ctx;
        public RepositoryBase(IContextBase ctx)
        {
            if(null==ctx)
            {
                throw new ArgumentNullException("ctx");
            }
            _ctx = ctx;
        }
        protected IDbSet<T> Entity
        {
            get 
            {
                return _ctx.GetSet<T>();
            }
        }
        protected void Modify(T entity)
        {
            _ctx.Entry<T>(entity).State = System.Data.EntityState.Modified;
        }
    }
}
