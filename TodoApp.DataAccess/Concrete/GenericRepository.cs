using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataAccess.Abstract;
using TodoApp.DataAccess.Context;
using TodoApp.Entity.Entities;

namespace TodoApp.DataAccess.Concrete
{
    public class GenericRepository<T>(SqlDbContext _context) : IRepository<T> where T : class
    {
        public void Create(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Remove(value);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
