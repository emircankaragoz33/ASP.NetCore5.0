using BL.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Concrete
{
    public class HeadManager : IGenericService<Head>
    {
        IHeadDal _headDal;
        public HeadManager(IHeadDal headDal)
        {
                _headDal    = headDal;
        }
        public void TAdd(Head entity)
        {
            _headDal.Add(entity);
        }

        public void TDelete(Head Entity)
        {
           _headDal.Delete(Entity);
        }

        public Head TGetById(int id)
        {
            return _headDal.GetById(id);
        }

        public List<Head> TGetList()
        {
            return _headDal.GetList();    
        }

        public void TUpdate(Head entity)
        {
           _headDal.Update  (entity);
        }
    }
}
