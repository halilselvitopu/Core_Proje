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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writermessagedal;

        public WriterMessageManager(IWriterMessageDal ıwritermessagedal)
        {
            _writermessagedal = ıwritermessagedal;
        }

        public void AddT(WriterMessage t)
        {
           _writermessagedal.Insert(t);
        }

        public void DeleteT(WriterMessage t)
        {
            _writermessagedal.Delete(t);
        }

        public WriterMessage GetByIdT(int id)
        {
          return _writermessagedal.GetById(id);
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writermessagedal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writermessagedal.GetByFilter(x => x.Sender == p);
        }

        public List<WriterMessage> GetListT()
        {
            throw new NotImplementedException();
        }


        public void UpdateT(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
