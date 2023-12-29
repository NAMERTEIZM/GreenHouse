namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunOnay")]
    public partial class UrunOnay
    {
        public Guid ID { get; set; }

        [StringLength(30)]
        public string TakipNumarasi { get; set; }

        public Guid? UrunID { get; set; }

        public bool? KullaniciGozukmeDurumu { get; set; }

        public Guid? EkleyenKullaniciRolID { get; set; }

        public Guid? InceleyenKullaniciRolID { get; set; }

        public bool? OnayDurumu { get; set; }

        public DateTime? IncelemeZamani { get; set; }

        public virtual KullaniciRolu KullaniciRolu { get; set; }

        public virtual KullaniciRolu KullaniciRolu1 { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
