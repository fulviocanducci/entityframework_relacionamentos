using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CslAppOrmEntityFramework.Models.Map
{
    public sealed class BookMap  :EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("book");

            HasKey(c => c.Id)
                .Property(c => c.Id)
                .HasColumnName("id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasMaxLength(50); 
        }
    }
}
