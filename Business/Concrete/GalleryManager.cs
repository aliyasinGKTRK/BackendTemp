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
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void Add(Gallery entity)
        {
            _galleryDal.Add(entity);
        }

        public void Delete(Gallery entity)
        {
            _galleryDal.Delete(entity);
        }

        public List<Gallery> GetAll()
        {
            return _galleryDal.GetAll();
        }

        public Gallery GetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public void Update(Gallery entity)
        {
            _galleryDal.Update(entity);
        }
    }
}
