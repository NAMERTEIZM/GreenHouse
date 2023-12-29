using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Risks
{
    public class RiskSelectVM
    {
        public int ID { get; set; }

        public string RiskTur { get; set; }

        public bool? AktifMi { get; set; }
        public override string ToString()
        {
            return RiskTur;
        }
    }
}
