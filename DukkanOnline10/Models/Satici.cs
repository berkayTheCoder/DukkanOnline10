using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Models
{
    public class Satici : IdentityUser
    {
        public ICollection<Envanter> UrunEnvanteri { get; set; }
        public int? DukkanId { get; set; }
        public Dukkan Dukkani { get; set; }
    }
}
