using System.Data.Entity.ModelConfiguration;

namespace CslAppOrmEntityFramework.Models.Map
{
    public sealed class AddressMap: EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("address");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();                  

            Property(x => x.City)
                .HasColumnName("city")
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Number)
                .HasColumnName("number")
                .IsRequired()
                .HasMaxLength(15);

            Property(x => x.Street)
                .HasColumnName("street")
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(x => x.Person)
                .WithOptional(x => x.Address);            
        }   
    }
}
