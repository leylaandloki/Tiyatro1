using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiyatro1
{
    internal class Tiyatro
    {
        int id;
        string oyunad;
        int oyunsuresi;
        DateTime oyuntarihi;
        string sahne;
        double fiyat;
        bool muzikal;

        public int Id { get => id; set => id = value; }
        public string Oyunad { get => oyunad; set => oyunad = value; }
        public int Oyunsuresi { get => oyunsuresi; set => oyunsuresi = value; }
        public DateTime Oyuntarihi { get => oyuntarihi; set => oyuntarihi = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }

        public Tiyatro(int id, string oyunad, int oyunsuresi, DateTime oyuntarihi, string sahne, double fiyat, bool muzikal)
        {
            this.id = id;
            this.oyunad = oyunad;
            this.oyunsuresi = oyunsuresi;
            this.oyuntarihi = oyuntarihi;
            this.sahne = sahne;
            this.fiyat = fiyat;
            this.muzikal = muzikal;
        }
    }
}
