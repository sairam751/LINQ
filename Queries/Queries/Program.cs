

using System;
using System.Linq;


namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
/*
            // Restriction
            var query= context
                .Courses
                .Where(c => c.Level == 1);
            foreach (var cours in query)
                Console.WriteLine(cours.Name);
*/

/*
            // Ordering

            var query1 = context.Courses
                            .OrderBy(c => c.Name)      
                            .ThenBy(c => c.Level);
            foreach (var cours in query1)
                Console.WriteLine(cours.Name);
*/

/*

            // Ordering by descending

            var query2 = context.Courses
                            .OrderByDescending(c => c.Name)
                            .ThenByDescending(c => c.Level);

            foreach (var cours in query2)
                Console.WriteLine(cours.Name);
*/

/*
            // Projection

            var query3 = context.Courses
                .Select(c => new
                        {
                                 CourseName = c.Name,
                                  AuthorName = c.Author.Name      //	no	join	required
                        });
            foreach (var cours in query3)
                Console.WriteLine("{0}--{1}", cours.CourseName, cours.AuthorName);
*/

/*
            //	flattens	hierarchical	lists	
            // If we select the object  that is a list then we can use select many to iterate through to the list.
            // Or else if we use select we should iterate using two for loops
            var tags = context.Courses.SelectMany(c => c.Tags);

            foreach (var x in tags)
                Console.WriteLine(x.Name);
*/

/*
            //select distinct

            var tags2 = context.Courses.SelectMany(c => c.Tags).Distinct();

            foreach (var x in tags2)
                Console.WriteLine(x.Name);
*/

/*

            //Grouping
            var groups = context.Courses.GroupBy(c => c.Level);

            foreach(var group in groups)
            {
                Console.WriteLine("Key:" + group.Key);
                foreach (var course in group)
                    Console.WriteLine("\t" + course.Name);
            }
*/


   /*         //Inner Join

            //Use when there is no relationship between your entities and you need to link them based on a key.

                        var authors = context.Authors.Join(context.Courses,
                    a => a.Id,      //	key	on	the	left	side	
                    c => c.AuthorId,            //	key	on	the	right	side,
                    (author, course) =>         //	what	to	do	once	matched
                                new
                                {
                                    AuthorName = author.Name,
                                    CourseName = course.Name
                                }
                       );
*/

/*
            // Group join

            //Left Join in sql

            //Useful when you need to group objects by a property and count the number of objects in each 
            // group.In SQL we do this with LEFT JOIN, COUNT(*) and GROUP BY.In LINQ, we use group
            //join

            var authors2 = context.Authors.GroupJoin(context.Courses,
                    a => a.Id,      //	key	on	the	left	side	
                    c => c.AuthorId,            //	key	on	the	right	side,
                    (author, courses) =>            //	what	to	do	once	matched
                                new
                                {
                                    AuthorName = author.Name,
                                    Courses = courses
                                }
                    );
*/

/*
            // Cross Join

            // To get full combinations of all objects on the left and the ones on the right. 

            var combos = context.Authors.SelectMany(a => context.Courses,
                (author, course) => new {
                    AuthorName = author.Name,
                    CourseName = course.Name
                });
*/

        }
    }
}
