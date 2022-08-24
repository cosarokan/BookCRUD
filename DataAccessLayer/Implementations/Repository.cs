using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class Repository<T, Id> : IRepository<T, Id> where T : class, new()
    {
        private readonly MyContext _myContext;

        public Repository(MyContext myContext)
        {
            _myContext = myContext;
        }
         

        public bool Add(T entity)
        {
            try
            {
                _myContext.Set<T>().Add(entity);
                return _myContext.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _myContext.Set<T>().Remove(entity);
                return _myContext.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _myContext.Set<T>().Update(entity);
                return _myContext.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<T> GetAll()
        {
            return _myContext.Set<T>().ToList();
        }

        public T GetById(Id id)
        {
            try
            {
                return _myContext.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
