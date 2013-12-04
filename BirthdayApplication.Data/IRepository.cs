using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApplication.Data
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);

        IQueryable<T> All();

        void Add(T entity);

        void Delete(int id);
    }
}
