using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void AddT(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void DeleteT(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public Portfolio GetByIdT(int id)
        {
           return _portfolioDal.GetById(id);
        }

        public List<Portfolio> GetListT()
        {
           return _portfolioDal.GetList();
        }

        public void UpdateT(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
    }
}
