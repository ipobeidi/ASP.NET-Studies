namespace FluentAPI.Migrations
{
    using FluentAPI.Entitys;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FluentAPI.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FluentAPI.PlutoContext context)
        {
            #region Add Tags
            var tags = new Dictionary<string, Tag>
            {
                {"c#", new Tag {Id = 1, Name = "c#"}},
                {"angularjs", new Tag {Id = 2, Name = "angularjs"}},
                {"javascript", new Tag {Id = 3, Name = "javascript"}},
                {"nodejs", new Tag {Id = 4, Name = "nodejs"}},
                {"oop", new Tag {Id = 5, Name = "oop"}},
                {"linq", new Tag {Id = 6, Name = "linq"}},
            };

            foreach (var tag in tags.Values)
                context.Tags.AddOrUpdate(t => t.Id, tag);
            #endregion

            #region Add Authors
            var authors = new List<Author>
            {
                new Author
                {
                    Id = 1,
                    Name = "Mosh Hamedani"
                },
                new Author
                {
                    Id = 2,
                    Name = "Anthony Alicea"
                },
                new Author
                {
                    Id = 3,
                    Name = "Eric Wise"
                },
                new Author
                {
                    Id = 4,
                    Name = "Tom Owsiak"
                },
                new Author
                {
                    Id = 5,
                    Name = "John Smith"
                }
            };

            foreach (var author in authors)
                context.Authors.AddOrUpdate(a => a.Id, author);
            #endregion

            #region Add Courses
            var courses = new List<Courses>
            {
                new Courses
                {
                    Id = 1,
                    Title = "C# Basics",
                    AuthorID = 1,
                    FullPrice = 49,
                    Description = "Description for C# Basics",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Courses
                {
                    Id = 2,
                    Title = "C# Intermediate",
                    AuthorID = 1,
                    FullPrice = 49,
                    Description = "Description for C# Intermediate",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"],
                        tags["oop"]
                    }
                },
                new Courses
                {
                    Id = 3,
                    Title = "C# Advanced",
                    AuthorID = 1,
                    FullPrice = 69,
                    Description = "Description for C# Advanced",
                    Level = 3,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Courses
                {
                    Id = 4,
                    Title = "Javascript: Understanding the Weird Parts",
                    AuthorID = 2,
                    FullPrice = 149,
                    Description = "Description for Javascript",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["javascript"]
                    }
                },
                new Courses
                {
                    Id = 5,
                    Title = "Learn and Understand AngularJS",
                    AuthorID = 2,
                    FullPrice = 99,
                    Description = "Description for AngularJS",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["angularjs"]
                    }
                },
                new Courses
                {
                    Id = 6,
                    Title = "Learn and Understand NodeJS",
                    AuthorID = 2,
                    FullPrice = 149,
                    Description = "Description for NodeJS",
                    Level = 2,
                    Tags = new Collection<Tag>()
                    {
                        tags["nodejs"]
                    }
                },
                new Courses
                {
                    Id = 7,
                    Title = "Programming for Complete Beginners",
                    AuthorID = 3,
                    FullPrice = 45,
                    Description = "Description for Programming for Beginners",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Courses
                {
                    Id = 8,
                    Title = "A 16 Hour C# Courses with Visual Studio 2013",
                    AuthorID = 4,
                    FullPrice = 150,
                    Description = "Description 16 Hour Courses",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["c#"]
                    }
                },
                new Courses
                {
                    Id = 9,
                    Title = "Learn JavaScript Through Visual Studio 2013",
                    AuthorID = 4,
                    FullPrice = 20,
                    Description = "Description Learn Javascript",
                    Level = 1,
                    Tags = new Collection<Tag>()
                    {
                        tags["javascript"]
                    }
                }
            };

            foreach (var cours in courses)
            {
                context.Course.AddOrUpdate(c => c.Id,cours);
            }
            #endregion
        }
    }
}
