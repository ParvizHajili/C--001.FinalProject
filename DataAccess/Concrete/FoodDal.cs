using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.TableModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class FoodDal : RepositoryBase<Food, ApplicationDbContext>, IFoodDal
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public List<Food> GetAllFoods()
        {
            return _context.Foods
                .Include(x => x.FoodCategory)
                .Where(x => x.Deleted == 0)
                .ToList();
        }
    }
}
