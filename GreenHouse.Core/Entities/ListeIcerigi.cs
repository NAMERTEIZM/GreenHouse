namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListeIcerigi")]
    public partial class ListeIcerigi
    {
        public Guid ID { get; set; }

        public Guid ListeID { get; set; }

        public bool? UrunMu { get; set; }

        public Guid IcerikID { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        public virtual KullaniciListesi KullaniciListesi { get; set; }
    }
}
