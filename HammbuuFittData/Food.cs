using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HammbuuFittData
{
    public class Food
    {
        public int FoodID { get; set; }
        public int CategoryID { get; set; }
        public string FoodName { get; set; }
        public int Calories { get; set; }
        public bool IsActive { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoPath { get; set; }

        // Navigation Properties
        public virtual Category Categories { get; set; }
        public virtual List<FoodMeal> FoodsMeals{ get; set; }
    }
}
