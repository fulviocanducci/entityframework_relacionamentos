using System.Data.Entity;
namespace CslAppOrmEntityFramework.Models
{
    public sealed class Ctx: DbContext
    {
        public Ctx()
            :base("name=MysqlConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<Ctx>(null);
        }
        
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Tag> Tag { get; set; }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }

        public DbSet<Client> Client { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Map.PersonMap());
            modelBuilder.Configurations.Add(new Map.AddressMap());
            modelBuilder.Configurations.Add(new Map.PostMap());
            modelBuilder.Configurations.Add(new Map.TagMap());

            modelBuilder.Configurations.Add(new Map.AuthorMap());
            modelBuilder.Configurations.Add(new Map.BookMap());
            modelBuilder.Configurations.Add(new Map.AuthorBookMap());

            modelBuilder.Configurations.Add(new Map.ClientMap());
            modelBuilder.Configurations.Add(new Map.ClientJuridicalMap());

        }
    }
}
