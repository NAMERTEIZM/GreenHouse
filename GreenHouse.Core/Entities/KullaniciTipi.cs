namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciTipi")]
    public partial class KullaniciTipi
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TipAdi { get; set; }

        public bool? AktifMi { get; set; }

        public int? HedefPuan { get; set; }
    }
}
