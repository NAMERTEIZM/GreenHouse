using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.DAL.Interfaces
{
    public interface IDeleteableRepo<T> where T:class
    {
        T HardDelete(T deleted);
        T SoftDelete(T deleted);
    }
}
