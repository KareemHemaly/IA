using Common.IRepository;
using ManagementSystem.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public class Repository<C, T> : IRepository<T> where T : class where C : SystemContext, new()
    {
        private C _entities = new C();
        public C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }


        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
            
        }

        public T Get(int Id)
        {
            return _entities.Set<T>().Find(Id);
        }

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
            this.Save();
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
            this.Save();
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
            this.Save();
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
