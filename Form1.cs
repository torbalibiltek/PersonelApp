
using System.ComponentModel;

namespace PersonelApp
{
    public partial class Form1 : Form
    {
        BindingList<Personel> liste = new(); //Personeller i�in liste tan�mlad�k
        Personel gosterilenPersonel;//ilerisi i�in ekranda g�r�nen personeli sakla

        public Form1()
        {
            InitializeComponent();

            //ListBox ile ba�lant� yap
            lbPersoneller.DataSource = liste;
            lbPersoneller.DisplayMember = "AdSoyad";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (gosterilenPersonel == null)//g�sterilen Personel Yok ise
                YeniEkle();
            else
                Guncelle();
        }

        void YeniEkle()
        {
            Personel yeniPers = new();//Personel s�n�f�ndan yeni bir nesne olu�turduk
            //Verileri form �zerinden kontrollerden ald�k 
            yeniPers.Ad = txtAd.Text;
            yeniPers.Soyad = txtSoyad.Text;
            yeniPers.Yas = Convert.ToInt32(txtYas.Text);
            yeniPers.Tel = txtTel.Text;
            yeniPers.Adres = txtAdres.Text;

            //Listeye ekleme i�lemi
            liste.Add(yeniPers);
            //alanlar� temizle
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
            //Bana listedeki se�ili olan eleman� Personel olarak ver
            Personel pers = lbPersoneller.SelectedItem as Personel;

            if (pers != null)//e�er veri geldiyse
            {
                //Personeli g�ster
                txtAd.Text = pers.Ad;
                txtSoyad.Text = pers.Soyad;
                txtYas.Text = pers.Yas.ToString();
                txtTel.Text = pers.Tel;
                txtAdres.Text = pers.Adres;

                gosterilenPersonel = pers;
                pbYeni.Visible = false;//yeni personel de�il bu
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
            //Se�ili personeli kald�r, yani yeni personel ekleyece�im
            lbPersoneller.SelectedIndex = -1;
            //alanlar� temizle
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
