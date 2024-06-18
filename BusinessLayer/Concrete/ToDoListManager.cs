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
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _ToDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _ToDoListDal = toDoListDal;
        }

        public void AddT(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public ToDoList GetByIdT(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> GetListT()
        {
          return _ToDoListDal.GetList();
        }

        public void UpdateT(ToDoList t)
        {
            throw new NotImplementedException();
        }
    }
}
