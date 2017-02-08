using System.Collections.Generic;

namespace CslAppOrmEntityFramework.Models
{
    public class Book
    {
        public Book()
        {
            AuthorsBook = new HashSet<AuthorBook>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<AuthorBook> AuthorsBook { get; set; }
    }
}
