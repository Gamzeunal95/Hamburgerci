using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.Entities.Abstract;
using Hamburgerci.Entities.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.EF.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity, new()   //Repository<T> yazdık içn T tipinden gelecek onu belirtiyoruz.Baseden gelecek.
    {
        protected readonly SqlDbContext dbcontext;

        public RepositoryBase()
        {
            this.dbcontext = new SqlDbContext();
        }


        public virtual int Add(T input)
        {
            dbcontext.Set<T>().Add(input);

            return dbcontext.SaveChanges();
        }

        public virtual int Delete(T input)
        {
            dbcontext.Set<T>().Remove(input);

            return dbcontext.SaveChanges();
        }

        // TODO : Pazartesi yapılacak. hata avr
        public virtual T Find(string name)
        {
            return dbcontext.Set<T>().Find(name);

        }

        public virtual IList<T> FindAll()
        {
            return dbcontext.Set<T>().ToList();
        }

        public virtual T FindById(int id)
        {
            return dbcontext.Set<T>().Find(id);
        }

        public virtual int Update(T input)
        {
            dbcontext.Set<T>().Update(input);

            return dbcontext.SaveChanges();
        }
    }
}
