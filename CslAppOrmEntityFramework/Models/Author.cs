using System.Collections.Generic;

namespace CslAppOrmEntityFramework.Models
{
    public class Author
    {
        public Author()
        {
            AuthorBooks = new HashSet<AuthorBook>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
