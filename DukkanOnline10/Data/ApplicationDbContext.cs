using System;
using System.Collections.Generic;
using System.Text;
using DukkanOnline10.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DukkanOnline10.Data
{
    public class ApplicationDbContext
                    : IdentityDbContext/*<
                        ApplicationUser, ApplicationRole, string,
                        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
                        ApplicationRoleClaim, ApplicationUserToken>*/
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Envanter> Envanters { get; set; }
        public DbSet<Siparis> Sipariss { get; set; }
        public DbSet<Sepet> Sepets { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Dukkan> Dukkans { get; set; }
        //identityuser dan türeyenler
        public DbSet<Satici> Saticis { get; set; }
        public DbSet<Musteri> Musteris { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Urun>().ToTable("Urun");
            modelBuilder.Entity<Envanter>().ToTable("Envanter");
            modelBuilder.Entity<Sepet>().ToTable("Sepet");
            modelBuilder.Entity<Siparis>().ToTable("Siparis");
            modelBuilder.Entity<Kategori>().ToTable("Kategori");
            modelBuilder.Entity<Dukkan>().ToTable("Dukkan");
            modelBuilder.Entity<Satici>().ToTable("Satici");
            modelBuilder.Entity<Musteri>().ToTable("Musteri");

            modelBuilder.Entity<Sepet>()
                .HasKey(c => new { c.EnvanterID, c.SiparisID });
            /*
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });
            modelBuilder.Entity<IdentityUser>(b =>
            {
                b.ToTable("MyUsers");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.ToTable("MyUserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.ToTable("MyUserLogins");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.ToTable("MyUserTokens");
            });

            modelBuilder.Entity<IdentityRole>(b =>
            {
                b.ToTable("MyRoles");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(b =>
            {
                b.ToTable("MyRoleClaims");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("MyUserRoles");
            });
            */
        }
    }
}
