# Hamburgerci

- BlankSolution açtık Hamburgerci Adında 
## Project 1 - HamburgerciEntities
- **Abstract**
   - BaseEntity Class (Abstract Class)
 
- **Concrete**
   - Extra (BaseEntity'den Kalıtım aldırdık)
   - Menu  (BaseEntity'den Kalıtım aldırdık)
   - SiparisMaster (BaseEntity'den Kalıtım aldırdık)
   - Kullanici (BaseEntity'den Kalıtım aldırdık)
   - SiparisDetay (BaseEntity'den Kalıtım aldırdık)
 
- **Contexts**
   - SqlDbContext (Ve her zaman Microsoft'un DbContext'inden kalıtım almayı unutma)
   - **NOT:** SqlDbContext içini SQL bağlantısını ve  Entity'lerimizin Ozelliklerini Fluent Api ile yazdık.

- Proje Dependences Packages kısmına aşağıdaki nuggetları indirdik.
   +  Microsoft.EntityFrameworkCore.SqlServer
   +  Microsoft.EntityFrameworkCore.Design
   +  Microsoft.EntityFrameworkCore.Tools
- Context'te yazmamız gerekenleri yazdıktan sonra terminalde projeye konumlanıyoruz, migrations olusturuyoruz ve DB'yi update ediyoruz.   

## Project 2 - Hamburgerci.DAL 
#### Dependences kısmından Add Project Reference - > HamburgerciEntities projesini referans verdik.
#### EF Folder (EntityFramework) (Bunu yapma amacımız başka bir Dapper ya da ADO.Net gibi farklı kullanımlar olacağı zaman klasörleme kolay olsun. )
 - **Abstract** 
    - IKulaniciDAL(interface)
    - IExtraDAL (interface)
    - IMenuDAL (interface)
    ####  Kod tekrar yaptığımız için 
    - IRepositoryBase açıldı. ve ortak özellikler yazıp <T> tipinden Generic yapıldı (Kullanici-Menu-Extra ne dersek T tipine o eklenecek.)
 - **Concrete**
    - KullaniciDAL (IKullaniciDAL'dan ve RepositoryBase<Kullanici>(<Kullanici> yazıldı çünkü bu classta T tipinde olan kısıma Kullanici gelecek) kalıtım aldık.)
    - RepositoryBase ( IRepositoryBase ve BaseEntity'den(Baseentity HamburgerciEntities projesinde) kalıtım aldık.)
    - ExtraDAL
    - MenuDAL    
            
RepositoryPattern Kullanıldı.
   
 ## Project 3 - Hamburgerci.WinUI WindowsFormApp(core)
 - Dependences kısmından Add Project Reference - > Diğer 2 projeyi
 - Form1 Ekran
*  GroupBox- 2 Label - 2 TextBox - 2 Buton
*  passwordchar * ekledik şifrenin textbox'una

 ## Project 4 - HamburgerciBL (BL = bussinesLogic (iş Katmanı))
 - İş kurallarının düzenlendiği kısım
 - **Abstract** 
   - IManagerBase
   - IKullaniciManager
 - **Concrete**  
   - ManagerBase
   - KulaniciManager
   
