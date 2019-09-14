using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Models
{
    public class Siparis
    {
        public int SiparisID { get; set; }
        public string MusteriID { get; set; }
        public Musteri Musteri { get; set; }
        public ICollection<Sepet> Sepetler { get; set; }
    }
}
