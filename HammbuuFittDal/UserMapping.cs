using HammbuuFittData;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammbuuFittDal
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("Users")
                .HasKey(x => x.UserID);
            Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            Property(x => x.LastName).HasMaxLength(50).IsRequired();
            Property(x => x.Age).IsRequired();
            Property(x => x.BasalMetabolismRate).IsRequired();
            Property(x => x.BodyMassIndex).IsRequired();
            Property(x => x.MailAddress).HasMaxLength(100).IsRequired();
            Property(x => x.UserName).HasMaxLength(100).IsRequired();
            Property(x => x.Password).HasMaxLength(100).IsRequired();
        }
    }
}
