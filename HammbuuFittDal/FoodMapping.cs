using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittDal
{
    public class FoodMapping : EntityTypeConfiguration<Food>
    {
        public FoodMapping()
        {
            ToTable("Food")
                .HasKey(x => x.FoodID);
            Property(x => x.FoodName).HasMaxLength(50).IsRequired();
            Property(x => x.Calories).IsRequired();
            Property(x => x.Photo).IsRequired();
            Property(x => x.PhotoPath).HasMaxLength(350);
        }
    }
}
