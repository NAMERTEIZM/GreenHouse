namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciAktivite")]
    public partial class KullaniciAktivite
    {
        [Key]
        [Column(Order = 0)]
        public Guid KullaniciRolID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AktiviteID { get; set; }

        public DateTime? AktiviteZamani { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        public virtual Aktivite Aktivite { get; set; }

        public virtual KullaniciRolu KullaniciRolu { get; set; }
    }
}
