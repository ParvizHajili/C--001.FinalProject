﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.TableModels;

namespace Business.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal = new FoodDal();
        public void Add(Food entity)
        {
            _foodDal.Add(entity);
        }

        public void Delete(Food entity)
        {
            throw new NotImplementedException();
        }

        public List<Food> GetAll()
        {
            return _foodDal.GetAllFoods();
        }

        public Food GetById(int id)
        {
            return _foodDal.GetById(id);
        }

        public void Update(Food entity)
        {
            _foodDal.Update(entity);
        }
    }
}
