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
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }

        public void AddT(Message t)
        {
            _messagedal.Insert(t);
        }

        public void DeleteT(Message t)
        {
            _messagedal.Delete(t);
        }

        public Message GetByIdT(int id)
        {
            return _messagedal.GetById(id);
        }

        public List<Message> GetListT()
        {
            return _messagedal.GetList();
        }

        public void UpdateT(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
