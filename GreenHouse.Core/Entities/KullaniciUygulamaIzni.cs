namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciUygulamaIzni")]
    public partial class KullaniciUygulamaIzni
    {
        public int ID { get; set; }

        public int? UygulamaIzinTipID { get; set; }

        public Guid? KullaniciRolID { get; set; }

        public bool? IzinDurumu { get; set; }

        public bool? AktifMi { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid? OlusturanKullaniciRolID { get; set; }

        public DateTime? DegistirilmeTarihi { get; set; }

        public Guid? DegistirenKullaniciRolID { get; set; }

        public virtual KullaniciRolu KullaniciRolu { get; set; }

        public virtual UygulamaIzinTip UygulamaIzinTip { get; set; }
    }
}
