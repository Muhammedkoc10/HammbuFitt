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
            Database.Connection.ConnectionString = @"Server=tcp:hammbu.database.windows.net,1433;Initial Catalog=HammbuFittDB;Persist Security Info=False;User ID=admin123;Password=HammbuFitt23;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodMeal> MealFoods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new FoodMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new MealMapping());
            modelBuilder.Configurations.Add(new FoodMealMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
