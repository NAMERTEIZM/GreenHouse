namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Eleman")]
    public partial class Eleman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eleman()
        {
            Menus = new HashSet<Menu>();
        }

        public int ID { get; set; }

        [StringLength(250)]
        public string MenuElemanAdi { get; set; }

        public string MenuIconYolu { get; set; }

        public int? MenuElemanSirasi { get; set; }

        public string MenuLinkAdresi { get; set; }

        public bool? AktifMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
