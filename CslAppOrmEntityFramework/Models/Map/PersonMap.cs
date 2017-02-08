using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CslAppOrmEntityFramework.Models.Map
{
    public sealed class PersonMap: EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable("person");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(50);

            HasOptional(x => x.Address)
                .WithRequired(x => x.Person);

            HasMany(c => c.Posts)
                .WithRequired(c => c.Person)
                .HasForeignKey(c => c.PersonId);
        }
    }
}
