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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialdal;

        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }

        public void AddT(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Testimonial t)
        {
            _testimonialdal.Delete(t);
        }

        public Testimonial GetByIdT(int id)
        {
            return _testimonialdal.GetById(id);
        }

        public List<Testimonial> GetListT()
        {
            return _testimonialdal.GetList();
        }

        public void UpdateT(Testimonial t)
        {
            _testimonialdal.Update(t); 
        }
    }
}
