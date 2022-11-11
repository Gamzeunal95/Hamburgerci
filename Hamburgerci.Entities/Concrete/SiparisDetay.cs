using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Concrete
{
    public class SiparisDetay : BaseEntity
    {
        public int SiparisMasterID { get; set; }
        public SiparisMaster SiparisMaster { get; set; } //Burasi DB'ye yansımayacak 
        public Menu Menu { get; set; }
        public double Adet { get; set; }

        public ICollection<Extra> Extralar { get; set; } 
        //Hesaplanabilir şeyleri DB'de tutmaya gerek yok

        [NotMapped] // Bunu yazdığımızda DB'de görünmez yazdığımız yerin hemen altındaki kodu sadece
        public double ToplamFiyat { get; set; }
    }
}
