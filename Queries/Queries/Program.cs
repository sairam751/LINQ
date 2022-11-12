
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();
/*
            //this can be seeen in SQL server instance

            //Deffered Exceution
            //this query will not execute immediately
            var courses = context.Courses.Where(c => c.Level == 1);


            //Intermediate Execution
             //this query will  execute immediately
            var courses1 = context.Courses.Where(c => c.Level == 1).ToList();
*/

             
        }
    }
}
