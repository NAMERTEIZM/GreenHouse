namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunFirma")]
    public partial class UrunFirma
    {
        [Key]
        [Column(Order = 0)]
        public Guid UrunID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid FirmaID { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        public virtual Firma Firma { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
