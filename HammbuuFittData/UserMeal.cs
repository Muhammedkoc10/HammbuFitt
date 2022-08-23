using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittData
{
    public class UserMeal
    {
        public int MealID { get; set; }
        public int UserID { get; set; }

        // Navigation Properties
        public virtual Meal MealsUser { get; set; }
        public virtual User UsersMeal { get; set; }
    }
}
