using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FluentAPI.Entitys
{
    public class Courses
    {
        public enum CourseLevel : byte
        {
            beginner = 1,
            Intermidiate = 2,
            Advance = 3

        }        
        
           public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public float FullPrice { get; set; }
            public Author Author { get; set; }
            public IList<Tag> Tags { get; set; }
            public int AuthorID  { get; set; }
            public CourseLevel Level { get; set; }
            public Cover Cover { get; set; }

    }
}
