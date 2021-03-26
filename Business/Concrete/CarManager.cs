using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Caching;
using Core.Aspect.Autofac.Performance;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
       
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
           _carDal.Add(car); 
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new ErrorResult(Messages.CarDeleted);
        }

        
        [CacheAspect] // key,value
        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        [CacheAspect]
        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>
                ( _carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails(int id)
        {
            return new SuccessDataResult< List < CarDetailDto >> (_carDal.GetCarDetails(id ));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails2()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails2());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        { 
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(cbr => cbr.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(cco => cco.ColorId == id));
        }

        
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult AddTransactionalTest(Car car)
        {
            throw new NotImplementedException();
        }

      
    }
}
