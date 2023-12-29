namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UygulamaIzinTip")]
    public partial class UygulamaIzinTip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UygulamaIzinTip()
        {
            KullaniciUygulamaIznis = new HashSet<KullaniciUygulamaIzni>();
        }

        public int ID { get; set; }

        [StringLength(200)]
        public string IzinKategoriAdi { get; set; }

        public int? UstKategoriIzinID { get; set; }

        public bool? AktifMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciUygulamaIzni> KullaniciUygulamaIznis { get; set; }
    }
}
