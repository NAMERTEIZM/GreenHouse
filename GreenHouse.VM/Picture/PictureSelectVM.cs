using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Picture
{
    public class PictureSelectVM
    {
        public Guid ID { get; set; }

        public Guid? UrunID { get; set; }

        public bool? ResimYuzu { get; set; }

        public string ResimYolu { get; set; }
    }
}
