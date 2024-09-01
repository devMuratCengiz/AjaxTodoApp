using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Entity.Entities;

namespace TodoApp.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetAll();
        void TCreate(T todo);
        void TDelete(int id);
    }
}
