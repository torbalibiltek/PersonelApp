
namespace PersonelApp
{
    public partial class Form1 : Form
    {
        List<Personel> liste = new(); //Personeller i�in liste tan�mlad�k

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
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
        }
    }
}
