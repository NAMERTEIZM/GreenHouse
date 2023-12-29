using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.DAL.Interfaces
{
    public interface IUpdatetableRepo<T> where T:class
    {
        T Update(T updated);
    }
}
