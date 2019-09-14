using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Models
{
    public class Musteri 
    {
        public ICollection<Siparis> Siparisleri { get; set; }

        public int EnvanterID { get; set; }
        public Envanter Envanter { get; set; }
        [Key]
        public string IdentityUserID { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
