using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.EF.Concrete
{
    public class KullaniciDAL : RepositoryBase<Kullanici>, IKullaniciDAL
    {
        public Kullanici FindByUserName(string userName, string password)    // IKullaniciDAL'da IRepositoryBasen ayrı ek bir özellik eklediğimiz için bu classta da kalıtım aldık buraya crtl. yaptık buraya geldi.
        {
            var user = base.dbcontext.Set<Kullanici>()
                .Where(p => p.KullaniciAdi == userName && p.Sifre == password)
                .FirstOrDefault();

            return user;
        }
    }
}
