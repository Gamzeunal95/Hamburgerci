using Hamburgerci.BL.Abstract;
using Hamburgerci.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.BL.Concrete
{
    public class KullaniciManager : ManagerBase<Kullanici>, IKullaniciManager
    {
        public KullaniciManager()
        {
        }

        public override int Add(Kullanici input)
        {
            var kullanici = FindByUserName(input.KullaniciAdi, input.Sifre);
            if (kullanici != null)
            {
                return -1;
            }
            return base.Add(input);
        }


        public Kullanici FindByUserName(string userName, string password)    // IKullaniciDAL'da IRepositoryBasen ayrı ek bir özellik eklediğimiz için bu classta da kalıtım aldık buraya crtl. yaptık buraya geldi.
        {
            var user = base.Find(userName);
            return user;
        }
    }
}
