using GreenHouse.Core;
using GreenHouse.VM.Risks;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.DAL.LogicsDAL
{
    public class RiskDAL
    {
        public List<RiskSelectVM> GetRisk()
        {
            EFRepo<Risk> riskDAL = new EFRepo<Risk>(new GreenHouseContext());

            List<RiskSelectVM> riskvm = new List<RiskSelectVM>();

            return riskDAL.SelectAll().Select(a => new RiskSelectVM()
            {
                ID = a.ID,
                RiskTur = a.RiskTur,
                AktifMi = a.AktifMi
            }).ToList();

        }

        public RiskInsertVM AddRisk(RiskInsertVM riskInsertVM)
        {

            EFRepo<Risk> riskDAL = new EFRepo<Risk>(new GreenHouseContext());

            MyEntityMapper<RiskInsertVM, Risk> mapper = new MyEntityMapper<RiskInsertVM, Risk>();
            Risk risk = mapper.Map<RiskInsertVM, Risk>(riskInsertVM);
            riskDAL.Add(risk);
            return riskInsertVM;
        }
        public RiskInsertVM UpdateRisk(RiskInsertVM riskInsertVM)
        {

            EFRepo<Risk> riskDAL = new EFRepo<Risk>(new GreenHouseContext());

            MyEntityMapper<RiskInsertVM, Risk> mapper = new MyEntityMapper<RiskInsertVM, Risk>();
            Risk risk = mapper.Map<RiskInsertVM, Risk>(riskInsertVM);
            riskDAL.Update(risk);
            return riskInsertVM;
        }
        public RiskSelectVM DeleteRisk(RiskSelectVM riskSelectVM)
        {
            EFRepo<Risk> riskDAL = new EFRepo<Risk>(new GreenHouseContext());

            MyEntityMapper<RiskSelectVM, Risk> mapper = new MyEntityMapper<RiskSelectVM, Risk>();
            Risk risk = mapper.Map<RiskSelectVM, Risk>(riskSelectVM);

            riskDAL.SoftDelete(risk);

            return riskSelectVM;
        }
    }
}
