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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void AddT(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement GetByIdT(int id)
        {
             return _announcementDal.GetById(id);
        }

        public List<Announcement> GetListT()
        {
            return _announcementDal.GetList();
            
        }

        public void UpdateT(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
