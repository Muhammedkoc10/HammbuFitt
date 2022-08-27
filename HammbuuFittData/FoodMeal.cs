using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittData
{
    public class FoodMeal
    {
        public int MealID { get; set; }
        public int FoodID { get; set; }
        public int UserID { get; set; }

        // Navigation Properties
        public virtual Meal MealsFood { get; set; }
        public virtual Food FoodsMeal { get; set; }
        public virtual User UsersMeal { get; set; }
    }
}
