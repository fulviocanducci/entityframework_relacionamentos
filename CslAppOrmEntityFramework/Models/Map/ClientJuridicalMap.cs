using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CslAppOrmEntityFramework.Models.Map
{
    public class ClientJuridicalMap: EntityTypeConfiguration<ClientJuridical>
    {
        public ClientJuridicalMap()
        {
            ToTable("clientjuridical");

            Property(c => c.Doc)
                .HasColumnName("doc")
                .HasMaxLength(14)
                .IsRequired();           
        }
    }
}
