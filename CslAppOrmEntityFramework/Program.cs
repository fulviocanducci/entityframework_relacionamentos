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

                //Post post = db.Post.Include("Tags")
                //    .Include("Person")
                //    .Where(c => c.Id == 4)
                //    .FirstOrDefault();

                //db.SaveChanges();

                //Author author = new Author();
                //author.Name = "Roberto de Abreu";

                //Book book = new Book();
                //book.Title = "Harry Potter";

                //AuthorBook authorBook = new AuthorBook();
                //authorBook.Author = author;
                //authorBook.Book = book;
                //authorBook.Year = 2005;


                //db.Author.Add(author);
                //db.Book.Add(book);
                //db.AuthorBook.Add(authorBook);

                //db.SaveChanges();

                //AuthorBook _ab = db.AuthorBook
                //    .Include("Author")
                //    .Include("Book")
                //    .Where(c => c.AuthorId == 2 && c.BookId == 2)
                //    .FirstOrDefault();

                //var a = db.Author
                //    .Include("AuthorBooks")
                //    .FirstOrDefault(c => c.Id == 1);  


                //Author author = new Author();
                //author.Name = "Roberto de Abreu III";

                //Book book = new Book();
                //book.Title = "Harry Potter III";

                //AuthorBook authorBook = new AuthorBook
                //{
                //    Author = author,
                //    Book = book,
                //    Year = 2015
                //};

                //db.Book.Add(book);
                //db.Author.Add(author);
                //db.AuthorBook.Add(authorBook);

                //db.SaveChanges();

                ClientJuridical cj = new ClientJuridical();
                cj.Doc = "12345678901234";
                cj.Name = "Client 1";

                db.Client.Add(cj);
                db.SaveChanges();
                
            }

            System.Console.ReadKey();
        }
    }
}
