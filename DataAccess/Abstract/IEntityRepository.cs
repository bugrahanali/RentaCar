using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new() // bu T yerine hem sadece class(yani ins string vs değil) hemmde IENTİTY içinden biri olcak demek ama sonuna new ekliyoruz ki IEntity kullanılamasın
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter );
        
        List<T> GetById(int brandId);
        void Add(T entity);
        void UpDate(T entity);
        void Delete(T entity);
    }
}
