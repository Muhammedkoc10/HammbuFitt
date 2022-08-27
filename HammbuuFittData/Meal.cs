using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittData
{
    public class Meal
    {
        public int MealID { get; set; }
        public string MealTime { get; set; }
        public DateTime AddedDate { get; set; }


        // Navigation Properties
        public virtual List<FoodMeal> FoodMeals { get; set; }
    }
}
