using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CslAppOrmEntityFramework.Models.Map
{
    public sealed class PostMap: EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            ToTable("post");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Title)
                .HasColumnName("title")
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Created)
                .HasColumnName("created")
                .IsRequired();

            Property(x => x.PersonId)
                .HasColumnName("personid")
                .IsRequired();

            HasRequired(x => x.Person)
                .WithMany(x => x.Posts)
                .HasForeignKey(c => c.PersonId);              

        }
    }
}
