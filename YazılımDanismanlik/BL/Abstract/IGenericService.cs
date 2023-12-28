using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TUpdate(T entity);
        List<T> TGetList();
        T TGetById(int id);

        void TDelete(T Entity);
    }
}
