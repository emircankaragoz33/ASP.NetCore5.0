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
    public class ServiceManager : IGenericService<Service>
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
                _serviceDal = serviceDal;
        }
        public void TAdd(Service entity)
        {
           _serviceDal.Add(entity);
        }

        public void TDelete(Service Entity)
        {
            _serviceDal.Delete(Entity);
        }

        public Service TGetById(int id)
        {
          return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service entity)
        {
           _serviceDal.Update(entity);
        }
    }
}
