namespace GreenHouse.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AramaGecmisi")]
    public partial class AramaGecmisi
    {
        public Guid ID { get; set; }

        public string AramaMetni { get; set; }

        public DateTime? AramaZamani { get; set; }

        public Guid? KullaniciRolID { get; set; }

        public bool? AktifMi { get; set; }
    }
}
