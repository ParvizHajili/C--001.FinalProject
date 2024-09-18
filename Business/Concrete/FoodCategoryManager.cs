using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.TableModels;

namespace Business.Concrete
{
    public class FoodCategoryManager : IFoodCategoryService
    {
        IFoodCategoryDal _foodCategoryDal = new FoodCategoryDal();
        public void Add(FoodCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FoodCategory entity)
        {
            throw new NotImplementedException();
        }

        public List<FoodCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public FoodCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(FoodCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
