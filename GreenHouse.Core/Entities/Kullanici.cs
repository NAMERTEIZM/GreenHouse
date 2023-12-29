namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            KullaniciRolus = new HashSet<KullaniciRolu>();
        }

        public Guid ID { get; set; }

        [StringLength(250)]
        public string Adi { get; set; }

        [StringLength(250)]
        public string Soyadi { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public bool? EmailOnayliMi { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciRolu> KullaniciRolus { get; set; }

        public string EmailKod {  get; set; }
        public bool PremiumMu { get; set; }
        public bool AdminOnayliMi { get; set; }
    }
}
