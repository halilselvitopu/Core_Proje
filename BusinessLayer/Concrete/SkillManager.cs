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
    public class SkillManager : ISkillService
    {
        ISkillDal _skilldal;

        public SkillManager(ISkillDal skillDal)
        {
            _skilldal = skillDal;
        }

        public void AddT(Skill t)
        {
            _skilldal.Insert(t);
        }

        public void DeleteT(Skill t)
        {
            _skilldal.Delete(t);    
        }

        public Skill GetByIdT(int id)
        {
            return _skilldal.GetById(id);
        }

        public List<Skill> GetListT()
        {
            return _skilldal.GetList();
        }

        public void UpdateT(Skill t)
        {
            _skilldal.Update(t);
        }
    }
}
