using System.Data.Entity.ModelConfiguration;

namespace CslAppOrmEntityFramework.Models.Map
{
    public class AuthorBookMap: EntityTypeConfiguration<AuthorBook>
    {
        public AuthorBookMap()
        {
            ToTable("authorsbooks");

            HasKey(a => new { a.AuthorId, a.BookId });
            Property(a => a.AuthorId)
                .IsRequired()
                .HasColumnName("authorid"); 
            Property(a => a.BookId)
                .IsRequired()
                .HasColumnName("bookid");

            Property(a => a.Year)
                .IsRequired()
                .HasColumnName("year");

            HasRequired(c => c.Author)
                .WithMany(c => c.AuthorBooks)
                .HasForeignKey(c => c.AuthorId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Book)
                .WithMany(c => c.AuthorsBook)
                .HasForeignKey(c => c.BookId)
                .WillCascadeOnDelete(false);
        }
    }
}
