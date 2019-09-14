using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Models
{
    public class Envanter
    {
        public int EnvanterID { get; set; }
        public string SaticiID { get; set; }
        public Satici UrunSaticisi { get; set; }
        public int UrunID { get; set; }
        public Urun SaticiUrunu { get; set; }
        public ICollection<Sepet> Sepetler { get; set; }
    }
}
