using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SliderManager : ISliderService
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Add(Slider entity)
        {
            _sliderDal.Add(entity);
        }

        public void Delete(Slider entity)
        {
            _sliderDal.Delete(entity);
        }

        public List<Slider> GetAll()
        {
            return _sliderDal.GetAll();
        }

        public Slider GetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public IList<Slider> GetList(Expression<Func<Slider, bool>> filter = null)
        {
           return _sliderDal.GetList();
        }

        public void Update(Slider entity)
        {
            _sliderDal.Update(entity);
        }
    }
}
