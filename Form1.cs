
using System.ComponentModel;

namespace PersonelApp
{
    public partial class Form1 : Form
    {
        BindingList<Personel> liste = new(); //Personeller için liste tanýmladýk

        public Form1()
        {
            InitializeComponent();
            //ListBox ile baðlantý yap
            lbPersoneller.DataSource = liste;
            lbPersoneller.DisplayMember = "Ad";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
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
        }
    }
}
