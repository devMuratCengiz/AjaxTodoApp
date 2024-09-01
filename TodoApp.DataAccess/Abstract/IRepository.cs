using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Entity.Entities;

namespace TodoApp.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        void Create (T item);
        void Delete(int id);

    }
}
