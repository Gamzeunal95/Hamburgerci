﻿using Hamburgerci.BL.Concrete;
using Hamburgerci.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.BL.Abstract
{
    public interface IKullaniciManager  : IManagerBase<Kullanici>
    {
        Kullanici FindByUserName(string userName, string password);   // Kullanici için Ek özellikleri ekledik. Bu özelliğin 
    }
}
