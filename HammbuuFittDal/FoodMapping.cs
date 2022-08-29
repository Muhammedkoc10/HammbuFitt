using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HammbuuFittDal
{
    public class FoodMapping : EntityTypeConfiguration<Food>
    {
        public FoodMapping()
        {
            ToTable("Foods")
                .HasKey(x => x.FoodID);
            Property(x => x.FoodName).HasMaxLength(150).IsRequired();
            Property(x => x.Calories).IsRequired();
            Property(x => x.Photo).HasColumnType("image");
        }
    }
}
