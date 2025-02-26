using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp
{
    public class Personel
    {
        public string Ad { get; set; }//auto property
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }

        private int yas;//field
        public int Yas //backing field property
        {
            get //property okunmak istediğinde 
            {
                return yas;
            }
            set//property yazılmak istendiğinde
            {
                //kontrol meknizması
                if (value > 0)
                {
                    yas = value;
                }
            }
        }
    
        public string AdSoyad//Readonly property
        {
            get { return Ad + " " + Soyad; }
        }
    }
}
