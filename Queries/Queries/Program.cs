
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
            var query =
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
            Console.ReadLine();
        }
        
    }
}
