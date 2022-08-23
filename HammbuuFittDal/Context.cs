using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittDal
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-5AELP68; Database=HammbuFittDB; uid=sa; pwd=123;";
        }

        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Food> Yemekler { get; set; }
        public DbSet<FoodMeal> ÖğünYemekleri { get; set; }
        public DbSet<Meal> Öğünler { get; set; }
        public DbSet<User> Kullacınılar { get; set; }
        public DbSet<UserMeal> ÖğünKullanıcıları { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new FoodMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new MealMapping());
            modelBuilder.Configurations.Add(new UserMealMapping());
            modelBuilder.Configurations.Add(new FoodMealMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
