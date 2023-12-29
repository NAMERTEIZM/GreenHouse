namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SayfaYetki")]
    public partial class SayfaYetki
    {
        public int ID { get; set; }

        public int? SayfaID { get; set; }

        public int? RolID { get; set; }

        public int? YetkiID { get; set; }

        public bool? AktifMi { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Sayfa Sayfa { get; set; }

        public virtual Yetki Yetki { get; set; }
    }
}
