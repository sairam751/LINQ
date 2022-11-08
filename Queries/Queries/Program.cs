
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new PlutoContext();

 /*      //To skip first 10 records and take 10 records.
            context.Courses.Skip(10).Take(10);
 */
        

/*
            // To get the first record
            //Throws an exception if no record is found
            context.Courses.First();
            context.Courses.First(c => c.Level == 1);
*/

/*            // Return first or default
            // Return Null if no record found.
            context.Courses.FirstOrDefault();
*/

/*
            //To get the last record
            // not supported by sql
            context.Courses.Last();
            context.Courses.LastOrDefault();
*/

/*
            // To get the single record

            context.Courses.Single(c => c.Id == 1);

            // to get the single record returns Nul;l if no record found
            context.Courses.SingleOrDefault(c => c.Id == 1);
*/

 /*           // Quantifing

            bool allInLevel1 = context.Courses.All(c => c.Level == 1);
            bool anyInLevel1 = context.Courses.Any(c => c.Level == 1);
*/

/*
            //Aggregating
            int count = context.Courses.Count();
            int count = context.Courses.Count(c => c.Level == 1);
            var max = context.Courses.Max(c => c.Price);
            var min = context.Courses.Min(c => c.Price);
            var avg = context.Courses.Average(c => c.Price);
            var sum = context.Courses.Sum(c => c.Price);
*/





        }
    }
}
