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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experiencedal;

        public ExperienceManager(IExperienceDal experiencedal)
        {
            _experiencedal = experiencedal;
        }

        public void AddT(Experience t)
        {
            _experiencedal.Insert(t);
        }

        public void DeleteT(Experience t)
        {
            _experiencedal.Delete(t);
        }

        public Experience GetByIdT(int id)
        {
            return _experiencedal.GetById(id);
        }

        public List<Experience> GetListT()
        {
            return _experiencedal.GetList();
        }

        public void UpdateT(Experience t)
        {
            _experiencedal.Update(t);
        }
    }
}
