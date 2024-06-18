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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void AddT(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage GetByIdT(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetListT()
        {
            return _userMessageDal.GetList();
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
           return _userMessageDal.GetUserMessagesWithUser();
        }

        public void UpdateT(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
