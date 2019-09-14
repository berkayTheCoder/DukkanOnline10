using System.Collections.Generic;

namespace DukkanOnline10.Models
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public ICollection<Urun> KategoriUrunleri { get; set; }

    }
}