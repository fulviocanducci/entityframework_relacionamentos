using System.Collections.Generic;
namespace CslAppOrmEntityFramework.Models
{
    public class Tag
    {
        public Tag()
        {
            Posts = new HashSet<Post>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
