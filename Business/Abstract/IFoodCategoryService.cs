using Entities.TableModels;

namespace Business.Abstract
{
    public interface IFoodCategoryService
    {
        void Add(FoodCategory entity);
        void Update(FoodCategory entity);
        void Delete(FoodCategory entity);
        List<FoodCategory> GetAll();
        FoodCategory GetById(int id);
    }

}
