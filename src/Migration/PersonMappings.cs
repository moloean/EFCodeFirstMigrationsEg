using System.Data.Entity.ModelConfiguration;
using Model;

namespace Migration.Mappings
{
    public class PersonMappings : EntityTypeConfiguration<Person>
    {
        public PersonMappings()
        {
            HasKey(x => x.IdentityNumber).Property(x => x.IdentityNumber)
                .HasMaxLength(11)
                .IsFixedLength();
        }
         
    }
}