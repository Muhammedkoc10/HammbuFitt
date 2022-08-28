using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittDal
{
    class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            ToTable("Categories")
                .HasKey<int>(x => x.CategoryID);
            Property(x => x.CategoryName).HasMaxLength(50).IsRequired();
            HasMany<Food>(x => x.Foods).WithRequired(x => x.Categories).HasForeignKey(x => x.CategoryID);
        }
    }
}
