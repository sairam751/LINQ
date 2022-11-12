
using System.Linq;

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

            // Modifing Data
            var course = context.Courses.Find(4);
            course.Name = "new name";
            //For foreign key
            course.AuthorId=2;

            context.SaveChanges();


        }
    }
}
