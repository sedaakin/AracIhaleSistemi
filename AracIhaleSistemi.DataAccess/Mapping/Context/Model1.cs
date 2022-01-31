using AracIhaleSistemi.DataAccess.Mapping.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace AracIhaleSistemi.DataAccess.Mapping.Context
{
    public partial class Model1 : DbContext
    {
        public Model1()
           // : base("name=Model1")
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=IkinciElAracIhaleDB_HufflePuf;Trusted_Connection=True;");
            //base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<AracDetay> AracDetay { get; set; }
        public virtual DbSet<AracDurum> AracDurum { get; set; }
        public virtual DbSet<AracOzellik> AracOzellik { get; set; }
        public virtual DbSet<AracTramerKaydi> AracTramerKaydi { get; set; }
        public virtual DbSet<Durum> Durum { get; set; }
        public virtual DbSet<FavoriArama> FavoriArama { get; set; }
        public virtual DbSet<FavoriAramaFiltre> FavoriAramaFiltre { get; set; }
        public virtual DbSet<Ihale> Ihale { get; set; }
        public virtual DbSet<IhaleArac> IhaleArac { get; set; }
        public virtual DbSet<IhaleDurum> IhaleDurum { get; set; }
        public virtual DbSet<Ilan> Ilan { get; set; }
        public virtual DbSet<IlanDurum> IlanDurum { get; set; }
        public virtual DbSet<KomisyonUcret> KomisyonUcret { get; set; }
        public virtual DbSet<NoterUcret> NoterUcret { get; set; }
        public virtual DbSet<PaketDetay> PaketDetay { get; set; }

        public virtual DbSet<PaketTip> PaketTip { get; set; }

        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<RolDetay> RolDetay { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<Sozlesme> Sozlesme { get; set; }
        public virtual DbSet<Tramer> Tramer { get; set; }
        public virtual DbSet<Uye> Uye{ get; set; }
        public virtual DbSet<UyeDetay> UyeDetay { get; set; }
        public virtual DbSet<UyeOzellik> UyeOzellik { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }
        public virtual DbSet<YetkiPage> YetkiPage { get; set; }
        public virtual DbSet<ChatBot> ChatBot { get; set; }
        public virtual DbSet<EkspertizMerkezi> EkspertizMerkezi { get; set; }
        public virtual DbSet<FavoriAramaDetay> FavoriAramaDetay { get; set; }
        public virtual DbSet<FavoriIlan> FavoriIlan { get; set; }
        public virtual DbSet<LogKayitlari> LogKayitlari { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
