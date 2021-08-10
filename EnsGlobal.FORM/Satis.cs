using System;

namespace EnsGlobal.FORM
{
    internal class Satis
    {
        public Satis()
        {
        }

        public int UrunID { get; set; }
        public string Yetkili { get; set; }
        public DateTime Tarih { get; set; }
        public int Ucret { get; set; }
        public int Vergi { get; set; }
    }
}