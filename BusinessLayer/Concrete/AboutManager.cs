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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void AddT(About t)
        {
            _aboutdal.Insert(t);
        }

        public void DeleteT(About t)
        {
           _aboutdal.Delete(t);
        }

        public About GetByIdT(int id)
        {
           return _aboutdal.GetById(id);
        }

        public List<About> GetListT()
        {
            return _aboutdal.GetList();
        }

        public void UpdateT(About t)
        {
            _aboutdal.Update(t);
        }
    }
}
