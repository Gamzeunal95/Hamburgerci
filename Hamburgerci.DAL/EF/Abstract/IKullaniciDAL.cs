using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hamburgerci.Entities;
using Hamburgerci.Entities.Concrete;
    

namespace Hamburgerci.DAL.EF.Abstract
{
    public interface IKullaniciDAL : IRepositoryBase<Kullanici>   // Kullanici Temel tüm entitilerde geçenleri IRepositoryBasen aldık.
    {
        Kullanici FindByUserName(string userName,string password);   // Ek özellikleri ekledik.

    }
}
