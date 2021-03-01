using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    //class -- reference type,       where T: = T can become class, IENtity and can do new()
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll();
        List<T> GetById();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
