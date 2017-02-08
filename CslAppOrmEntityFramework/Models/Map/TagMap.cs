using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace CslAppOrmEntityFramework.Models.Map
{
    public class TagMap : EntityTypeConfiguration<Tag>
    {
        public TagMap()
        {
            ToTable("tag");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Description)
                .HasColumnName("description")
                .IsRequired()
                .HasMaxLength(50);

            HasMany(c => c.Posts)
                .WithMany(c => c.Tags)
                .Map(c => 
                {
                    c.ToTable("poststags");
                    c.MapLeftKey("tagid");
                    c.MapRightKey("postid");                    
                });
        }
    }
}
