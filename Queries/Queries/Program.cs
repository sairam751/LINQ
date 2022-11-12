
using System.Linq;
using System.Data;
using System.Data.Entity;
using System;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            /*
                        //Adding data


                        // In this approch the forien keys will not assign to the existing author it will create a new author in DB. 
                        var course = new Course
                        {
                            Name = "LINQ ADDED",
                            Description = "Added from the LINQ",
                            FullPrice = 20F,
                            Level = 1,
                            Author = new Author { Id = 1, Name = "Sai" }

                        };

                        //WPF approch
                        //First approch
                        // In this fist we get the author from the DB and then assign it to the new data.
                        var authors = context.Authors.ToList();
                        var author = context.Authors.Single(a => a.Id == 1);
                         var course2 =  new Course
                         {
                             Name = "LINQ ADDED",
                             Description = "Added from the LINQ",
                             FullPrice = 20F,
                             Level = 1,
                             Author = author

                         };

                        //WPF approch
                        //Second approch
                        // In this we direct provide the value of the forien key propertie[AuthorId]

                        var course3 = new Course
                        {
                            Name = "LINQ ADDED",
                            Description = "Added from the LINQ",
                            FullPrice = 20F,
                            Level = 1,
                            AuthorId = 1

                        };
              context.Courses.Add(course);

 */
            /*
                        // Modifing Data
                        var course = context.Courses.Find(4);
                        course.Name = "new name";
                        //For foreign key
                        course.AuthorId=2;

                        
            */

            /*           
                       // Deleting Data

                       // Cascade Delete [All the related rows will also be deleted (Tags in this case)]

                       var course = context.Courses.Find(4);
                       context.Courses.Remove(course);

                       //Wihout Cascade Delete[Cascade delete is set to off]
                       //In that case first remove child rows and delete the parent.
                       //Cascade delet can be turned off in the plutocontext class and in method OnModelCreating()


                       var author = context.Authors.Include(a => a.Courses).Single(a => a.Id == 2);
                       context.Courses.RemoveRange(author.Courses);
                       context.Authors.Remove(author);
           */

            //Change tracker
            //There uis a change tracter in entity framework when we exceute the save change method the entity frame
            //work will look into chnage tracker and cvert sql queries accordingly. 


            //Add an object
            context.Authors.Add(new Author { Name = "new Author" });

            //update object
            var author = context.Authors.Find(4);
            author.Name = "updated";


            //Delete an object
            var author2 = context.Authors.Find(4);
            context.Authors.Remove(author2);


            var entries = context.ChangeTracker.Entries();
            foreach(var entry in entries)
            {

                //state will contain either modified,updated or deleted.
                Console.WriteLine(entry.State);
            }
            context.SaveChanges();
        }
    }
}
