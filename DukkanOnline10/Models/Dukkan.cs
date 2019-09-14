using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Models
{
    public class Dukkan
    {
        [Key]
        public int DukkanId { get; set; }
        public string DukkanAdi { get; set; }
        [StringLength(50)]
        [Display(Name = "Dükkanın Yeri")]
        public string Location { get; set; }
        public Satici DukkanSahibi { get; set; }
    }
}
