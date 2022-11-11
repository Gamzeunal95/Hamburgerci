using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.DAL.EF.Concrete;
using Hamburgerci.Entities.Concrete;

namespace Hamburgerci.WinUI
{
    public partial class Form1 : Form
    {
        readonly IKullaniciDAL kullaniciDAL;
        public Form1()
        {
            InitializeComponent();
            kullaniciDAL = new KullaniciDAL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }           

        private void button2_Click(object sender, EventArgs e)
        {
          
            int sonuc = kullaniciDAL.Add(new Kullanici()
            {
                Adi = txtKullanici.Text,
                Soyadi = "Yilmaz",
                KullaniciAdi = txtKullanici.Text,
                Sifre = txtSifre.Text,
            });
            if (sonuc > 0)
            {
                MessageBox.Show("Kayýt Baþarýlý");
            }
            else
            {
                MessageBox.Show("Hata Olustu");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kullanici = kullaniciDAL.FindByUserName(txtKullanici.Text , txtSifre.Text);
            if (kullanici != null)
            {
                MessageBox.Show(kullanici.Adi + " " + kullanici.Soyadi);
            }
        }
    }
}