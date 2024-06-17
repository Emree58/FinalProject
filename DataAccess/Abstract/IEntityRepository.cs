using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint (generik kisitlama) where T:class welke T? enkel class
    //Class : referans tip olacak, IEntitiyden implement edecek yada IEntitye bagli class
    //IEntity : Ientity olabilir, veya implemente eden bir nesne (concrete maptaki)
    //new() : new'lenebilir olmali verdigin <-->
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
