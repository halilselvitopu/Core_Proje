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
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void AddT(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public WriterUser GetByIdT(int id)
        {
             return _writerUserDal.GetById(id);
        }

        public List<WriterUser> GetListT()
        {
           return _writerUserDal.GetList();
        }

        public void UpdateT(WriterUser t)
        {
            throw new NotImplementedException();
        }
    }
}
