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
            throw new NotImplementedException();
        }

        public Message GetByIdT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListT()
        {
            throw new NotImplementedException();
        }

        public void UpdateT(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
