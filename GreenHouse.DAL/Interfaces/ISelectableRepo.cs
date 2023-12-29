using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.DAL.Interfaces
{
    public interface ISelectableRepo<T> where T:class
    {
        T SelectByID(string ID);
        List<T> SelectByID(Expression<Func<T, bool>> filter);
        List<T> SelectAll(Expression<Func<T,bool>> filter);
        List<T> SelectAll();
        //UOW
        //IQueryable<T> SelectAll(Expression<Func<T, bool>> filter);

    }
}
