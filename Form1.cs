
using System.ComponentModel;

namespace PersonelApp
{
    public partial class Form1 : Form
    {
        BindingList<Personel> liste = new(); //Personeller için liste tanýmladýk
        Personel gosterilenPersonel;//ilerisi için ekranda görünen personeli sakla

        public Form1()
        {
            InitializeComponent();

            //ListBox ile baðlantý yap
            lbPersoneller.DataSource = liste;
            lbPersoneller.DisplayMember = "AdSoyad";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (gosterilenPersonel == null)//gösterilen Personel Yok ise
                YeniEkle();
            else
                Guncelle();
        }

        void YeniEkle()
        {
            Personel yeniPers = new();//Personel sýnýfýndan yeni bir nesne oluþturduk
            //Verileri form üzerinden kontrollerden aldýk 
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyad.Text;
            yeniPers.Yas = Convert.ToInt32(txtYas.Text);
            yeniPers.Tel = txtTel.Text;
            yeniPers.Adres = txtAdres.Text;

            //Listeye ekleme iþlemi
            liste.Add(yeniPers);
            //alanlarý temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTel.Clear();
            txtAdres.Clear();
            //ilk kontrole TtxtAd odaklan
            txtAd.Focus();
        }

        private void lbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bana listedeki seçili olan elemaný Personel olarak ver
            Personel pers = lbPersoneller.SelectedItem as Personel;

            if (pers != null)//eðer veri geldiyse
            {
                //Personeli göster
                txtAd.Text = pers.Ad;
                txtSoyad.Text = pers.Soyad;
                txtYas.Text = pers.Yas.ToString();
                txtTel.Text = pers.Tel;
                txtAdres.Text = pers.Adres;

                gosterilenPersonel = pers;
                pbYeni.Visible = false;//yeni personel deðil bu
            }
            else
            {
                gosterilenPersonel = null;
                pbYeni.Visible = true;//bu yeni personel
            }
        }

        void Guncelle()
        {
            gosterilenPersonel.Ad = txtAd.Text;
            gosterilenPersonel.Soyad = txtSoyad.Text;
            gosterilenPersonel.Yas = Convert.ToInt32(txtYas.Text);
            gosterilenPersonel.Tel = txtTel.Text;
            gosterilenPersonel.Adres = txtAdres.Text;

            //Listeyi yenile
            liste.ResetBindings();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //Seçili personeli kaldýr, yani yeni personel ekleyeceðim
            lbPersoneller.SelectedIndex = -1;
            //alanlarý temizle
            txtAd.Clear();
            txtSoyad.Clear();
            txtYas.Clear();
            txtTel.Clear();
            txtAdres.Clear();
            //ilk kontrole TtxtAd odaklan
            txtAd.Focus();
        }
    }
}
