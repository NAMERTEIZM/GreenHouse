namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunIcerik")]
    public partial class UrunIcerik
    {
        [Key]
        [Column(Order = 0)]
        public Guid UrunID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid BilesenID { get; set; }

        public bool? AktifMİ { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        public virtual Bilesen Bilesen { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
