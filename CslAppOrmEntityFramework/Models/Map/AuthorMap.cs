using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CslAppOrmEntityFramework.Models.Map
{
    public sealed class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("author");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("id")
                .IsRequired();

            Property(x => x.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(50); 
        }
    }
}
