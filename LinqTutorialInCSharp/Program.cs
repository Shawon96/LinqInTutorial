using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorialInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //var querySyntax = (from num in dataSource
            //                  where num <= 5 || num>9
            //                  select num).ToList();

            //var methodSyntax = dataSource.Where(num => num <= 5 || num > 9).ToList();

            //var dataSource = new List<String> { "Tom","Harry","Adom","Ponting"};
            //var querySyntax = (from num in dataSource
            //                   where num.Length==3
            //                   select num).ToList();

            //var methodSyntax = dataSource.Where(num => num.Length == 3).ToList();

            //var dataSource = new List<Employee>
            //{
            //    new Employee{Id = 1, Name = "Tom", Email = "tom@email.com", Programming = 
            //    new List<Techs>
            //     {
            //        new Techs{ Technology = "C#"},
            //        new Techs{ Technology = "PHP"},
            //        new Techs{ Technology = ".Net"},
            //        new Techs{ Technology = "MVC"},
            //        new Techs{ Technology = "SQL"}
            //     }
            //    },

            //    new Employee{Id = 2, Name = "John", Email = "john@email.com", Programming =
            //    new List<Techs>
            //     {
            //        new Techs{ Technology = "C#"},
            //        new Techs{ Technology = "VB"},
            //        new Techs{ Technology = "SQL"}
            //     }
            //    },

            //    new Employee{Id = 3, Name = "Mark", Email = "mark@email.com", Programming =
            //    new List<Techs>
            //     {
            //        new Techs{ Technology = "LINQ"},
            //        new Techs{ Technology = "MVC"}
            //     }
            //    },
            //    new Employee{Id = 4, Name = "Kim", Email = "kim@email.com", Programming = new List<Techs>()},
            //    new Employee{Id = 5, Name = "Adom", Email = "adom@email.com", Programming = new List<Techs>()}
            //};

            //var querySyntax = (from emp in dataSource
            //                   where emp.Programming.Count == 2 && emp.Id == 4
            //                   select emp).ToList();

            //var methodSyntax = dataSource.Where(x => x.Programming.Count > 3 && x.Name == "Kim").ToList();

            Console.ReadLine();
        }
    }
}
