namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aktivite")]
    public partial class Aktivite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aktivite()
        {
            KullaniciAktivites = new HashSet<KullaniciAktivite>();
        }

        public int ID { get; set; }

        [StringLength(200)]
        public string AktiviteAdi { get; set; }

        public int? Puan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciAktivite> KullaniciAktivites { get; set; }
    }
}
