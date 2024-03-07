using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experience)
        {
            _experienceDal = experience;
        }
        public Experience TGetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }

        public List<Experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
