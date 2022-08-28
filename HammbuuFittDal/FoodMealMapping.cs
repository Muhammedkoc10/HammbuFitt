using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittDal
{
    public class FoodMealMapping : EntityTypeConfiguration<FoodMeal>
    {
        public FoodMealMapping()
        {
            ToTable("Foods Meals")
                .HasKey(x => new { x.FoodID, x.MealID,x.UserID});
            HasRequired(y => y.FoodsMeal).WithMany(z => z.FoodsMeals);
            HasRequired(y => y.MealsFood).WithMany(z => z.FoodMeals);
            HasRequired(y => y.UsersMeal).WithMany(z => z.UsersFoods);
        }
    }
}
