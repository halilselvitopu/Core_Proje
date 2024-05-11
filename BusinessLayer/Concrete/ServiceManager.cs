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
    public class ServiceManager : IServiceService
    {
        IServiceDal _servicedal;

        public ServiceManager(IServiceDal servicedal)
        {
            _servicedal = servicedal;
        }

        public void AddT(Service t)
        {
           _servicedal.Insert(t);
        }

        public void DeleteT(Service t)
        {
            _servicedal.Delete(t);
        }

        public Service GetByIdT(int id)
        {
            return _servicedal.GetById(id);
        }

        public List<Service> GetListT()
        {
          return _servicedal.GetList();
        }

        public void UpdateT(Service t)
        {
            _servicedal.Update(t);
        }
    }
}
