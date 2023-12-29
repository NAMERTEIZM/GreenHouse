using GreenHouse.Core;
using GreenHouse.VM.Category;
using GreenHouse.VM.Risks;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using GreenHouse.DAL.LogicsDAL;

namespace GreenHouse.BLL.Logic
{
    public class RiskManager
    {
        RiskDAL RiskDAL;

        public RiskManager()
        {
            RiskDAL = new RiskDAL();
        }

        public List<RiskSelectVM> GetRisk()
        {
            return RiskDAL.GetRisk();

        }

        public RiskInsertVM AddRisk(RiskInsertVM riskInsertVM)
        {
            return RiskDAL.AddRisk(riskInsertVM);
        }
        public RiskInsertVM UpdateRisk(RiskInsertVM riskInsertVM)
        {
            return RiskDAL.AddRisk(riskInsertVM);
        }
        public RiskSelectVM DeleteRisk(RiskSelectVM riskSelectVM)
        {
            return RiskDAL.DeleteRisk(riskSelectVM);
        }
    }
}
