namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firma")]
    public partial class Firma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firma()
        {
            UrunFirmas = new HashSet<UrunFirma>();
        }

        public Guid ID { get; set; }

        [StringLength(200)]
        public string FirmaAdi { get; set; }

        [StringLength(200)]
        public string FirmaTel { get; set; }

        public string FirmaAdresi { get; set; }

        public bool? AktifMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunFirma> UrunFirmas { get; set; }
    }
}
