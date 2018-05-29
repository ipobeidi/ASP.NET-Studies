using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();



            /*Aggregations
            var count = context.Courses.Count();
            context.Courses.Max(c => c.FullPrice);
            context.Courses.Min(c => c.FullPrice);
            context.Courses.Average(c => c.FullPrice);

            /* Quantifying
            var allCoursesAbove10Dollars = context.Courses.All(c => c.FullPrice < 10);
            context.Courses.Any(c => c.Level == 1);

            /* Element Operators
            context.Courses.OrderBy(c => c.Level).FirstOrDefault( c => c.FullPrice > 100);
            context.Courses.SingleOrDefault(c => c.Level == 1);
            

            /* Cross Join
            context.Courses.SelectMany(a => context.Courses, (authors, courses) => new
            {
                AuthorName = authors.Name,
                Courses = courses.Name
            });

             *GROUP JOIN
            context.Authors.GroupJoin(context.Courses, a => a.Id, c => c.AuthorId, (authos, courses) => new
            {
                Authors = authos,
                CourseName = courses
            } );
            
            * INNER JOIN extend
            var querie = context.Courses.Join(context.Authors, 
                            c => c.AuthorId, 
                            a => a.Id,
                            (course, authors) => new
                            {
                                    CourseName = course.Name,
                                    AuthorName = authors.Name
                            });
             Group by
            var groups = context.Courses.GroupBy(c => c.Level);

            foreach (var g in groups)
            {
                Console.WriteLine("Key: " +g.Key);

                foreach (var courses in g)
                {
                    Console.WriteLine("\t " + courses.Name);
                }

            }              

            Projection
            var querie = context.Courses.Where(c => c.Level == 1)
                .OrderBy(c => c.Author)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(c => c.Level)
                .SelectMany(c=>c.Tags)
                //SetOperators
                .Distinct();

            foreach (var c in querie)
            {
                foreach (var tags in c)
                {
                    Console.WriteLine(tags.Name);
                }
            }
            * Extension methos Order
            var querie = context.Courses.Where(c => c.Level == 1 )
                .OrderBy(c => c.Author)
                .OrderByDescending( c => c.Name)
                .ThenByDescending(c => c.Level);
            * Linq Extension methods Restriction
            var querie = context.Courses.Where(c => c.Level == 1);
            
            /* Extension methods example
              var courses = context.Courses
                .Where(c => c.Name.Contains("c#"))
                .OrderBy(c => c.Name);
            foreach (var courss in courses)
            {
                Console.WriteLine(courss.Name);
            }

            
            /* Linq Syntax
             * Group join
            var query =
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new { AuthorName = a.Name, courses = g.Count() };

            foreach (var x in query)
            {
                Console.WriteLine("{0} ({1})", x.AuthorName, x.courses);

            }
                LINQ JOIN                  
              var querie = from c in context.Courses              
                join a in context.Authors on c.AuthorId equals a.Id
                select new { CourseName = c.Name, AuthorName = a.Name };
            // linq syntax

            var querie =
                from c in context.Courses
                where c.Name.Contains("c#")
                orderby c.Name
                select c;

            foreach (var course in querie)
            {
                Console.WriteLine(course.Name);
            }

             */


            Console.ReadKey();
            
        }
    }
}
