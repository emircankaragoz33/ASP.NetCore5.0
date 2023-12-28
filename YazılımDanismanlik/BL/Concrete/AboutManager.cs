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
    public class AboutManager : IGenericService<About>
    {
      readonly  IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal; 
        }
        public void TAdd(About entity)
        {
           _aboutDal.Add(entity);
        }

        public void TDelete(About Entity)
        {
           _aboutDal.Delete(Entity);    
        }

        public About TGetById(int id)
        {
           return _aboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
           return _aboutDal.GetList();
        }

        public void TUpdate(About entity)
        {
           _aboutDal.Update(entity);
        }
    }
}
