using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        T GetById(int id);
    }
}
