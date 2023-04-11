using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorialInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int> { 1, 5, 2, 4, 9, 3 };
            var dataSourceString = new List<String> { "Jibon", "Akash", "PrapTi", "BullShit", "Jamela", "Karim" };

            var methodSyntaxForInt = dataSourceInt.OrderByDescending(x => x).ToList();

            var methodSyntaxForString = dataSourceString.OrderByDescending(x => x).ToList();

            var querySyntaxForInt = (from qs in dataSourceInt
                                     orderby qs descending
                                     select qs).ToList();

            var querySyntaxForString = (from qs in dataSourceString
                                        orderby qs descending
                                        select qs).ToList();


            var dataSource = new List<Employee>
            {
                new Employee{Id = 1, Name = "Tom", Email = "tom@email.com"},
                new Employee{Id = 4, Name = "Kim", Email = "kim@email.com"},
                new Employee{Id = 2, Name = "John", Email = "john@email.com"},
                new Employee{Id = 3, Name = "Mark", Email = "mark@email.com"},
                new Employee{Id = 5, Name = "Adom", Email = "adom@email.com"}
            };

            var querySyntax = (from emp in dataSource
                               orderby emp.Id descending
                               select emp).ToList();
            var methodSyntax = dataSource.OrderByDescending(x => x.Id).ToList();

            Console.ReadLine();
        }
    }
}
