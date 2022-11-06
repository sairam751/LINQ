
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

            /*
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
            */


            /*
            // Inner Join

            //Use when there is  relationship between your entities
            // As it has navigation propert in course of entity author so no need to join separately
            var query =
                from  c in context.Courses
                   select new { CourseName = c.Name, AuthorName = c.Author.Name };

            foreach (var group in query)
            {
                Console.WriteLine(group.CourseName );
                Console.WriteLine(group.AuthorName);
            }

            */

            /*
            // Inner Join

            //Use when there is no relationship between your entities and you need to link them based on a key.

              var query =
              from a in context.Authors
              join c in context.Courses on a.Id equals c.AuthorId
              select new { Course = c.Name, Author = a.Name };

            foreach (var group in query)
            {
                Console.WriteLine(group.Course);
                Console.WriteLine(group.Author);
            }
            */


            /* 
             
            // Group Join

            //Left join in sql

            var query =
            from a in context.Authors
            join c in context.Courses on a.Id equals c.AuthorId into g
            select new { AuthorName = a.Name, Courses = g.Count() };

            foreach (var x in query)
            {
                Console.WriteLine("{0} {1}", x.AuthorName,x.Courses);
            }

            */


            // Cross Join

            // Full join in sql
            var query =
            from a in context.Authors
            from c in context.Courses
            select new { AuthorName = a.Name, CourseName = c.Name };


            foreach (var x in query)
            {
                Console.WriteLine("{0} {1}", x.AuthorName, x.CourseName);
            }
            Console.ReadLine();
        }
        
    }
}
