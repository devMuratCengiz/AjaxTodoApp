using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Business.Abstract;
using TodoApp.DataAccess.Abstract;
using TodoApp.Entity.Entities;

namespace TodoApp.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {
        public void TCreate(T todo)
        {
            _repository.Create(todo);
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public List<T> TGetAll()
        {
            return _repository.GetAll();
        }
    }
}
