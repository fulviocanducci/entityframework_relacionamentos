using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace CslAppOrmEntityFramework.Models.Map
{
    public sealed class ClientMap :EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            ToTable("client");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
