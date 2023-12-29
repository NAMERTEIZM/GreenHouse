namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciListesi")]
    public partial class KullaniciListesi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KullaniciListesi()
        {
            KullaniciListesi1 = new HashSet<KullaniciListesi>();
            ListeIcerigis = new HashSet<ListeIcerigi>();
        }

        public Guid ID { get; set; }

        [StringLength(300)]
        public string ListeAdi { get; set; }

        public Guid? ÜstListeID { get; set; }

        public Guid? KullaniciRolID { get; set; }

        public int? ListeTipiID { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciListesi> KullaniciListesi1 { get; set; }

        public virtual KullaniciListesi KullaniciListesi2 { get; set; }

        public virtual KullaniciRolu KullaniciRolu { get; set; }

        public virtual ListeTip ListeTip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListeIcerigi> ListeIcerigis { get; set; }
    }
}
