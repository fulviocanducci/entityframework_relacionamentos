using CslAppOrmEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CslAppOrmEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Ctx db = new Ctx())
            {
                db.Database.Log = Console.WriteLine;

                //Person p = new Person();
                //p.Name = "Lorena Ideal";
                //p.Address = new Address
                //{
                //    Id = p.Id,
                //    City = "New Orleans",
                //    Number = "300-C",
                //    Street = "Street C"
                //};

                //db.Person.Add(p);


                //Address address = new Address
                //{
                //    Person = new Person
                //    {
                //        Name = "Ruibam"
                //    },                    
                //    City = "Detroit Piston",
                //    Number = "300-Z",
                //    Street = "Street Z"
                //};

                //db.Address.Add(address);

                //Person p = new Person
                //{
                //    Name = "Paul Autran"
                //};

                //db.Person.Add(p);

                //Person p = db.Person.Include("Address").Where(c => c.Id == 5).FirstOrDefault();
                //if (p.Address == null) p.Address = new Address();
                //p.Address.Number = "699 - Jovem";
                //p.Address.City = "Lodon";
                //p.Address.Street = "Street Ophran";


                //Tag tag = new Tag();
                //tag.Description = "Asp.Net.Core";



                //db.Tag.Add(tag);

                //Tag tag = db.Tag.Find(2);
                //Person person = db.Person.Find(2);

                //Post post = new Post();
                //post.Person = person;
                //post.Title = "Csharp Language Runtime";
                //post.Created = DateTime.Now.AddDays(-5);
                //post.Tags.Add(tag);

                //db.Post.Add(post);                

                Post post = db.Post.Include("Tags")
                    .Include("Person")
                    .Where(c => c.Id == 4)
                    .FirstOrDefault();

                //db.SaveChanges();
            }

            System.Console.ReadKey();
        }
    }
}
