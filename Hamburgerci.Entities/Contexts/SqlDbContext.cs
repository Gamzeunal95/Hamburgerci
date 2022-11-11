using Hamburgerci.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.Entities.Contexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<Extra> Extralar { get; set; }
        public DbSet<Kullanici> Kullancilar { get; set; }
        public DbSet<SiparisMaster> SiparisMaster { get; set; }

        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }

        //Bu bölüm hangi Database vendor ile iletisim kuracağını belirlediğimiz yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                                                          Database=Hamburgerci;
                                                          Trusted_Connection=true");
                  
        }

        // Burası Entity'lerimizin Ozelliklerini Fluent Api ayarladığımız yer
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .Property(p => p.MenuAdi).HasMaxLength(50);
            // MenuAdi uniqe olacak
            modelBuilder.Entity<Menu>().HasIndex(p => p.MenuAdi).IsUnique();


            modelBuilder.Entity<Extra>()
                 .Property(p => p.ExtraAdi).HasMaxLength(50);
            // ExtraAdi uniqe olacak
            modelBuilder.Entity<Extra>().HasIndex(p => p.ExtraAdi).IsUnique();


            modelBuilder.Entity<Kullanici>()
               .Property(p => p.Adi).HasMaxLength(50);
            modelBuilder.Entity<Kullanici>()
                .Property(p => p.Soyadi).HasMaxLength(50);
            modelBuilder.Entity<Kullanici>()
                .Property(p => p.KullaniciAdi).HasMaxLength(50);
            modelBuilder.Entity<Kullanici>()
                .Property(p => p.Sifre).HasMaxLength(50);

            //KullaniciAdi uniqe olacak. 
            modelBuilder.Entity<Kullanici>().HasIndex(p => p.KullaniciAdi).IsUnique();

        }

    }
}
