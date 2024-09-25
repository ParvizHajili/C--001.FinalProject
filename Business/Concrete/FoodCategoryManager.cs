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
            _foodCategoryDal.Add(entity);
        }

        public void Delete(FoodCategory entity)
        {
            _foodCategoryDal.Delete(entity);
        }

        public List<FoodCategory> GetAll()
        {
            return _foodCategoryDal.GetAll(x => x.Deleted == 0);
        }

        public FoodCategory GetById(int id)
        {
            return _foodCategoryDal.GetById(id);
        }

        public void Update(FoodCategory entity)
        {
            entity.LastUpdatedDate = DateTime.Now;
            _foodCategoryDal.Update(entity);
        }
    }
}
