
using System;
using System.Linq;


namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
            //LINQ SYNTAX
            //To get all c# cources
            /*var query =
                from c in context.Courses
                where c.Name.Contains("c#")
                orderby c.Name
                select c;

            foreach (var cours in query)
                Console.WriteLine(cours.Name);

            //Extension Methods
            var course = context.Courses.
                    Where(c => c.Name.Contains("c#"))
                    .OrderBy(c => c.Name);
            foreach (var c1 in course)
                Console.WriteLine(c1.Name);
            Console.ReadLine();*/

            /*// combine where expression
            var query =
                from c in context.Courses
                where c.Level == 1 && c.Author.Id == 1
                select c;
            foreach (var cours in query)
                Console.WriteLine(cours.Name);*/


            /*// Order command
            var query =
                from c in context.Courses
                where c.Level == 1
                orderby c.Level descending, c.Name
                select c;
            foreach (var cours in query)
                Console.WriteLine(cours.Name);
           */

            /*
            //Projections
            var query =
               from c in context.Courses
               select new { Course = c.Name, AuthorName = c.Author.Name };

            foreach (var cours in query)
                Console.WriteLine(cours);
            */

            /* //GROUP BY
             //No need of use group by aggregate
            var query= from c in context.Courses
             group c by c.Level 
             into g
             select g;
             foreach (var group in query)
             {
                 Console.WriteLine(group.Key);

                 foreach (var cours in group)
                     Console.WriteLine(cours.Name);
             }*/

            //Aggregate Functions

            var query = 
                from c in context.Courses
           group c by c.Level
           into g
           select g;
            foreach (var group in query)
            {
                Console.WriteLine("{0}-{1}" , group.Key, group.Count());
            }
            Console.ReadLine();
        }
        
    }
}
