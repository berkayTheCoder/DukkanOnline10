using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public decimal UrunFiyati { get; set; }
        public int Stok { get; set; }
        public Kategori Kategorisi { get; set; }
        public ICollection<Envanter> SaticiEnvanteri { get; set; }
    }
}
