using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittDal
{
    public class MealMapping : EntityTypeConfiguration<Meal>
    {
        public MealMapping()
        {
            ToTable("Öğün")
                .HasKey(x => x.MealID);
            Property(x => x.MealTime).HasMaxLength(30);
            HasMany<FoodMeal>(x => x.FoodMeals).WithRequired(x => x.MealsFood).HasForeignKey(x => x.MealID);
            HasMany<UserMeal>(x => x.UsersMeals).WithRequired(x => x.MealsUser).HasForeignKey(x => x.MealID);
        }
    }
}
