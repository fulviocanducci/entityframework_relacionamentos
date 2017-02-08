using System;
using System.Collections.Generic; 
namespace CslAppOrmEntityFramework.Models
{
    public class Post
    {
        public Post()
        {
            Tags = new HashSet<Tag>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; } 
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
