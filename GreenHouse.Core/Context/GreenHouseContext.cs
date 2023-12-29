using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GreenHouse.Core
{
    public partial class GreenHouseContext : DbContext
    {
        public GreenHouseContext()
            : base("server=DESKTOP-EVHNVRA\\SQLEXPRESS;Database=GreenHouseDB;integrated security=true")
        {
        }

        public virtual DbSet<Aktivite> Aktivites { get; set; }
        public virtual DbSet<AramaGecmisi> AramaGecmisis { get; set; }
        public virtual DbSet<Bilesen> Bilesens { get; set; }
        public virtual DbSet<Eleman> Elemen { get; set; }
        public virtual DbSet<Firma> Firmas { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciAktivite> KullaniciAktivites { get; set; }
        public virtual DbSet<KullaniciListesi> KullaniciListesis { get; set; }
        public virtual DbSet<KullaniciRolu> KullaniciRolus { get; set; }
        public virtual DbSet<KullaniciTipi> KullaniciTipis { get; set; }
        public virtual DbSet<KullaniciUygulamaIzni> KullaniciUygulamaIznis { get; set; }
        public virtual DbSet<ListeIcerigi> ListeIcerigis { get; set; }
        public virtual DbSet<ListeTip> ListeTips { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Resim> Resims { get; set; }
        public virtual DbSet<Risk> Risks { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Sayfa> Sayfas { get; set; }
        public virtual DbSet<SayfaYetki> SayfaYetkis { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<UrunFirma> UrunFirmas { get; set; }
        public virtual DbSet<UrunIcerik> UrunIceriks { get; set; }
        public virtual DbSet<UrunKategori> UrunKategoris { get; set; }
        public virtual DbSet<UrunOnay> UrunOnays { get; set; }
        public virtual DbSet<UygulamaAyar> UygulamaAyars { get; set; }
        public virtual DbSet<UygulamaIzinTip> UygulamaIzinTips { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aktivite>()
                .HasMany(e => e.KullaniciAktivites)
                .WithRequired(e => e.Aktivite)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bilesen>()
                .HasMany(e => e.UrunIceriks)
                .WithRequired(e => e.Bilesen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eleman>()
                .HasMany(e => e.Menus)
                .WithMany(e => e.Elemen)
                .Map(m => m.ToTable("MenuEleman").MapLeftKey("ElemanID").MapRightKey("MenuID"));

            modelBuilder.Entity<Firma>()
                .HasMany(e => e.UrunFirmas)
                .WithRequired(e => e.Firma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciListesi>()
                .HasMany(e => e.KullaniciListesi1)
                .WithOptional(e => e.KullaniciListesi2)
                .HasForeignKey(e => e.ÜstListeID);

            modelBuilder.Entity<KullaniciListesi>()
                .HasMany(e => e.ListeIcerigis)
                .WithRequired(e => e.KullaniciListesi)
                .HasForeignKey(e => e.ListeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.KullaniciAktivites)
                .WithRequired(e => e.KullaniciRolu)
                .HasForeignKey(e => e.KullaniciRolID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.KullaniciListesis)
                .WithOptional(e => e.KullaniciRolu)
                .HasForeignKey(e => e.KullaniciRolID);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.KullaniciUygulamaIznis)
                .WithOptional(e => e.KullaniciRolu)
                .HasForeignKey(e => e.KullaniciRolID);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.UrunOnays)
                .WithOptional(e => e.KullaniciRolu)
                .HasForeignKey(e => e.EkleyenKullaniciRolID);

            modelBuilder.Entity<KullaniciRolu>()
                .HasMany(e => e.UrunOnays1)
                .WithOptional(e => e.KullaniciRolu1)
                .HasForeignKey(e => e.InceleyenKullaniciRolID);

            modelBuilder.Entity<ListeTip>()
                .HasMany(e => e.KullaniciListesis)
                .WithOptional(e => e.ListeTip)
                .HasForeignKey(e => e.ListeTipiID);

            modelBuilder.Entity<Menu>()
                .HasMany(e => e.Sayfas)
                .WithMany(e => e.Menus)
                .Map(m => m.ToTable("SayfaMenu").MapLeftKey("MenuID").MapRightKey("SayfaID"));

            modelBuilder.Entity<Urun>()
                .Ignore(e=> e.AktifMi)
                .HasMany(e => e.UrunFirmas)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .Ignore(e => e.AktifMi)
                .HasMany(e => e.UrunIceriks)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UrunKategori>()
                .HasMany(e => e.Uruns)
                .WithOptional(e => e.UrunKategori)
                .HasForeignKey(e => e.KategoriID);

            modelBuilder.Entity<UrunKategori>()
                .HasMany(e => e.UrunKategori1)
                .WithOptional(e => e.UrunKategori2)
                .HasForeignKey(e => e.UstKategoriID);
        }
    }
}
