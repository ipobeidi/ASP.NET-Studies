using System.Collections.Generic;
using static CodeFirst.Program;

namespace CodeFirst.Entidades
{
     public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> tag { get; set; }
        public CourseLevel Level { get; set; }


    }
}
