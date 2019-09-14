using DukkanOnline10.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DukkanOnline10.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Uruns.Any())
            {
                return;   // DB has been seeded
            }
            var Kategoris = new Kategori[]
            {
                new Kategori { KategoriAdi = "Giyim&Ayakkabı"},
                new Kategori { KategoriAdi = "Ev/Yaşam"},
                new Kategori { KategoriAdi = "Elektronik"},
                new Kategori { KategoriAdi = "Anne/Bebek"}
            };

            foreach (Kategori d in Kategoris)
            {
                context.Kategoris.Add(d);
            }
            context.SaveChanges();

            var Uruns = new Urun[]
{
                new Urun {UrunID = 1050, UrunAdi = "Bilgisayar",      Stok = 3,
                    KategoriID = Kategoris.Single( s => s.KategoriAdi == "Elektronik").KategoriID
                },
                new Urun {UrunID = 4022, UrunAdi = "Biberon", Stok = 3,
                    KategoriID = Kategoris.Single( s => s.KategoriAdi == "Anne/Bebek").KategoriID
                },
                new Urun {UrunID = 4041, UrunAdi = "Zıbın", Stok = 3,
                    KategoriID = Kategoris.Single( s => s.KategoriAdi == "Anne/Bebek").KategoriID
                },
                new Urun {UrunID = 1045, UrunAdi = "Battaniye",       Stok = 4,
                    KategoriID = Kategoris.Single( s => s.KategoriAdi == "Ev/Yaşam").KategoriID
                },
                new Urun {UrunID = 3141, UrunAdi = "Sehpa",   Stok = 4,
                    KategoriID = Kategoris.Single( s => s.KategoriAdi == "Ev/Yaşam").KategoriID
                },
                new Urun {UrunID = 2021, UrunAdi = "Tişört",    Stok = 3,
                    KategoriID = Kategoris.Single( s => s.KategoriAdi == "Giyim&Ayakkabı").KategoriID
                },
                new Urun {UrunID = 2042, UrunAdi = "Pantolon",     Stok = 4,
                    KategoriID = Kategoris.Single( s => s.KategoriAdi == "Giyim&Ayakkabı").KategoriID
                },
};

            foreach (Urun c in Uruns)
            {
                context.Uruns.Add(c);
            }
            context.SaveChanges();

            var Saticis = new Satici[]
            {
                new Satici { UserName = "Berkay" },
                new Satici { UserName = "Abercrombie" },
                new Satici { UserName = "Fakhouri" },
                new Satici { UserName = "Harui" },
                new Satici { UserName = "Kapoor" },
                new Satici { UserName = "Zheng" }
            };

            foreach (Satici i in Saticis)
            {
                context.Saticis.Add(i);
            }
            context.SaveChanges();

            var Envanterler = new Envanter[]
            {
#region BerkayEnvanteri		
                new Envanter {
                    SaticiID = Saticis.Single(i => i.UserName == "Berkay").Id,
                    UrunID = 1050,
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Biberon" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Berkay").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Zıbın" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Berkay").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Battaniye" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Berkay").Id
                    }, 
#endregion
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Bilgisayar" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Berkay").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Bilgisayar" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Harui").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Biberon" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Zheng").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Zıbın" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Zheng").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Battaniye" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Fakhouri").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Sehpa" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Harui").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Tişört" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Abercrombie").Id
                    },
                new Envanter {
                    UrunID = Uruns.Single(c => c.UrunAdi == "Pantolon" ).UrunID,
                    SaticiID = Saticis.Single(i => i.UserName == "Abercrombie").Id
                    },
            };

            foreach (Envanter ci in Envanterler)
            {
                context.Envanters.Add(ci);
            }
            context.SaveChanges();

            var Musteris = new Musteri[]
            {
                new Musteri { UserName = "Alexander" },
                new Musteri { UserName = "Alonso" },
                new Musteri { UserName = "Anand" },
                new Musteri { UserName = "Barzdukas" },
                new Musteri { UserName = "Li" },
                new Musteri { UserName = "Justice" },
                new Musteri { UserName = "Norman" },
                new Musteri { UserName = "Berkay" }
            };
            
            foreach (Musteri s in Musteris)
            {
                context.Musteris.Add(s);
            }
            context.SaveChanges();

            var Siparisler = new Siparis[]
            {
                new Siparis
                {
                    MusteriID = Musteris.Single(s => s.UserName == "Alonso").Id,
                },
                new Siparis
                {
                    MusteriID = Musteris.Single(s => s.UserName == "Li").Id,
                },
                new Siparis
                {
                    MusteriID = Musteris.Single(s => s.UserName == "Berkay").Id,
                },
                new Siparis
                {
                    Musteri = Musteris[7]
                }
            };

            foreach (Siparis e in Siparisler)
            {
                var VeriTabanindakiSiparisler = context.Sipariss
                    .Where( s => s.Musteri.Id == e.MusteriID ).SingleOrDefault();
                if (VeriTabanindakiSiparisler == null)
                {
                    context.Sipariss.Add(e);
                }
            }
            context.SaveChanges();

            var Users = new IdentityUser[]
            {
                new IdentityUser{ UserName = "Şükrü Berkay", Email = "sukruberkay@dukkanonline.com", PhoneNumber = "5398220128" },
                new IdentityUser{ UserName = "Toygar2", Email = "toygar@dukkanonline.com", PhoneNumber = "5398220128" },
                new IdentityUser{ UserName = "Toygar3", Email = "toygar@dukkanonline.com", PhoneNumber = "5398220128" },
                new IdentityUser{ UserName = "Toygar4", Email = "toygar@dukkanonline.com", PhoneNumber = "5398220128" },
                new IdentityUser{ UserName = "Toygar5", Email = "toygar@dukkanonline.com", PhoneNumber = "5398220128" },
                new IdentityUser{ UserName = "Toygar6", Email = "toygar@dukkanonline.com", PhoneNumber = "5398220128" },
            };
            foreach (var u in Users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var Roller = new IdentityRole[]
            {
                new IdentityRole{Name="Satici"},
                new IdentityRole{Name="Musteri"},
                new IdentityRole{Name="KategoriYoneticisi"},
                new IdentityRole{Name="Admin"},
            };
            foreach (var r in Roller)
            {
                context.Roles.Add(r);
            }
            context.SaveChanges();

            var UserRoles = new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>
                {
                    UserId = Saticis.Single(s=>s.UserName=="Şükrü Berkay").Id,
                    RoleId = Roller.Single(r=>r.Name=="Admin").Id,
                },
                new IdentityUserRole<string>
                {
                    UserId = Users.Single(s=>s.UserName=="Toygar2").Id,
                    RoleId = Roller.Single(r=>r.Name=="KategoriYoneticisi").Id,
                },
                new IdentityUserRole<string>
                {
                    UserId = Saticis.Single(s=>s.UserName=="Berkay").Id,
                    RoleId = Roller.Single(r=>r.Name=="Satici").Id,
                },
                new IdentityUserRole<string>
                {
                    UserId = Musteris.Single(s=>s.UserName=="Alexander").Id,
                    RoleId = Roller.Single(r=>r.Name=="Musteri").Id,
                },
            };
            foreach (var u in UserRoles)
            {
                context.UserRoles.Add(u);
            }
            context.SaveChanges();

        }
    }
}
