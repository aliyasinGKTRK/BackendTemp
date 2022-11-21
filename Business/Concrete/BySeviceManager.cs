using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BySeviceManager : IByServiceService
    {
        IServiceDal _serviceDal;

        public BySeviceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service entity)
        {
            _serviceDal.Add(entity);
        }

        public void Delete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public List<Service> GetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void Update(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
