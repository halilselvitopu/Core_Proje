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
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public void AddT(Contact t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact GetByIdT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetListT()
        {
           return  _contactdal.GetList();
        }

        public void UpdateT(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
