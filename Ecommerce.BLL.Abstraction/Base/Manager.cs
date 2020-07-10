using Ecommerce.Repository.Abstraction.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.BLL.Abstraction.Base
{
    public abstract class Manager<T> where T : class
    {
        IRepository<T> _repository;
        public Manager(IRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }
        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }
        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }
        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFirstOrDefault(predicate);
        }
    }
}
