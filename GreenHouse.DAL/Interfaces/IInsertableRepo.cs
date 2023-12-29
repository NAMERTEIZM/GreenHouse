using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.DAL.Interfaces
{
    public interface IInsertableRepo<T> where T:class
    {
        T Add(T inserted);
        //async
    }
}
