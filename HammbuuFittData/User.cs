using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittData
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public decimal BasalMetabolismRate { get; set; }
        public decimal BodyMassIndex { get; set; }
        public bool IsActive { get; set; }
        public string MailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsSportsman { get; set; }


        // Navigation Propertys
        public virtual List<FoodMeal> UsersFoods { get; set; }
    }
}
