using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        int Add(T p);
        int Delete(T p);
        int Update(T p);
        List<T> GetAll();
        T getByID(int id);
    }
}
