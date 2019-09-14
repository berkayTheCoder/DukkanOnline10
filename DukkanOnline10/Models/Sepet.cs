using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Models
{
    public class Sepet
    {
        public int EnvanterID { get; set; }
        public Envanter Envanter { get; set; }
        public int SiparisID { get; set; }
        public Siparis Siparis { get; set; }
    }
}
