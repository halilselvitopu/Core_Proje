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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featuredal;

        public FeatureManager(IFeatureDal featuredal)
        {
            _featuredal = featuredal;
        }

        public void AddT(Feature t)
        {
            _featuredal.Insert(t);
        }

        public void DeleteT(Feature t)
        {
            _featuredal.Delete(t);
        }

        public Feature GetByIdT(int id)
        {
            return _featuredal.GetById(id);
        }

        public List<Feature> GetListT()
        {
            return _featuredal.GetList();
        }

        public void UpdateT(Feature t)
        {
            _featuredal.Update(t);
        }
    }
}
