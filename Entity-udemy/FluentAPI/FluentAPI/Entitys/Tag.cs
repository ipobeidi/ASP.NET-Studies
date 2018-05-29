using System.Collections.Generic;
using static FluentAPI.Entitys.Courses;

namespace FluentAPI.Entitys
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Courses> Courses { get; set; }
    }
}