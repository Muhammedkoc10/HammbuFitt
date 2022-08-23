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
            ToTable("Yemek Öğün")
                .HasKey(x => new { x.FoodID, x.MealID });
            HasRequired(y => y.FoodsMeal).WithMany(z => z.FoodsMeals);
            HasRequired(y => y.MealsFood).WithMany(z => z.FoodMeals);
        }
    }
}
