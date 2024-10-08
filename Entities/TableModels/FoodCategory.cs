﻿using Core.Entities.Abstract;

namespace Entities.TableModels
{
    public class FoodCategory : BaseEntity, IEntity
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }
        public string Name { get; set; }
        public string IconName { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}
