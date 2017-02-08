using System.Collections;
using System.Collections.Generic;

namespace CslAppOrmEntityFramework.Models
{
    public class Person
    {
        public Person()
        {
            Posts = new HashSet<Post>();
        }
        public int Id { get; set; }
        public string Name { get; set; }           
        public virtual Address Address { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
