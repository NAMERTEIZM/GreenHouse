namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UygulamaAyar")]
    public partial class UygulamaAyar
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Adi { get; set; }

        public string LogoResimYolu { get; set; }

        public bool? KullanimKosullariniGostermeDurumu { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }
    }
}
