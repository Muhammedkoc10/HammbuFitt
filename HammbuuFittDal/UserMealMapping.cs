using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittDal
{
    class UserMealMapping : EntityTypeConfiguration<UserMeal>
    {
        public UserMealMapping()
        {
            ToTable("Kullanıcı Öğün")
                .HasKey(x => new { x.UserID, x.MealID });
            HasRequired(y => y.MealsUser).WithMany(z => z.UsersMeals);
            HasRequired(y => y.UsersMeal).WithMany(z => z.UsersMeal);
        }
    }
}
