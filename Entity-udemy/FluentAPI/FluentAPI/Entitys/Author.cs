using System.Collections.Generic;
using static FluentAPI.Entitys.Courses;

namespace FluentAPI.Entitys
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Courses> Course { get; set; }
    }
}