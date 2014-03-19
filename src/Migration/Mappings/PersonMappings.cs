using System.Data.Entity.ModelConfiguration;
using model;

namespace Migration.Mappings
{
    public class PersonMappings : EntityTypeConfiguration<IPerson>
    {
        public PersonMappings()
        {
            HasKey(e => e.IdentityNumber)
                .Property(e => e.IdentityNumber)
                .HasMaxLength(11)
                .IsFixedLength();

            Property(e => e.FirstName)
                .IsRequired();
        }
         
    }
}