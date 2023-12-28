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
    public class WebUserManager : IWebUserService
    {
        IWebUserDal _webUserDal;

        public WebUserManager(IWebUserDal webUserDal)
        {
            _webUserDal = webUserDal;
        }
        public void TAdd(WebUser entity)
        {
            _webUserDal.Add(entity);    
        }

        public void TDelete(WebUser Entity)
        {
          _webUserDal.Delete(Entity);
        }

        public WebUser TGetById(int id)
        {
            return _webUserDal.GetById(id); 
        }

        public List<WebUser> TGetList()
        {
            return _webUserDal.GetList();
        }

        public void TUpdate(WebUser entity)
        {
          _webUserDal.Update(entity);
        }
    }
}
