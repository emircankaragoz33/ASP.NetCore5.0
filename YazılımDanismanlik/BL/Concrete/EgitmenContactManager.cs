using BL.Abstract;
using DAL.Abstract;
using DAL.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Concrete
{
    public class EgitmenContactManager : IGenericService<EgitmenContact>
    {
        IEgitmenContactDal _contactDal;
        public EgitmenContactManager(IEgitmenContactDal contactDal)
        {
                _contactDal = contactDal;
        }
        public void TAdd(EgitmenContact entity)
        {
           _contactDal.Add(entity);
        }

        public void TDelete(EgitmenContact Entity)
        {
          _contactDal.Delete(Entity);
        }

        public EgitmenContact TGetById(int id)
        {
           return _contactDal.GetById(id); 
        }

        public List<EgitmenContact> TGetList()
        {
           return  _contactDal.GetList();
        }

        public void TUpdate(EgitmenContact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
