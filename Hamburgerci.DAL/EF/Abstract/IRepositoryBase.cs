using Hamburgerci.Entities.Abstract;
using Hamburgerci.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.EF.Abstract
{
    // IExtraDAL - IMenuDAL - IKullaniciDAL bunların içlerinde hep kod tekrarı yaptığımız için
    // RepositoryBase diye bir interface açtık ve T tipinden bir değer verdik tek tek extra-kullanıcı-menu diye adlandırmadık.
    public interface IRepositoryBase<T> where T : BaseEntity, new() // BaseEntityden kalıtım alanları dahil etmek istediğimiz için BaseEntity yazdık yoksa  vaşka classta yazılabilirdi.
    {                                                               // BaseEntityden kalıtım alanların newlenmesini istediğimiz için new() yazdık.    
        T FindById(int id);
        T Find(string name);
        IList<T> FindAll();

        int Add(T input);
        int Update(T input);
        int Delete(T input);
    }
}
