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
    public class ContactManager : IGenericService<Contact>
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void TAdd(Contact entity)
        {
          _contactDal.Add   (entity);
        }

        public void TDelete(Contact Entity)
        {
          _contactDal.Delete (Entity);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById (id);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TUpdate(Contact entity)
        {
           _contactDal.Update   (entity);
        }
    }
}
