using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorialInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Object> { "Akash", "Shuvo", "Nafi", 1, 2, 3, 4, 5 };

            var methodSyntax = dataSource.OfType<int>().ToList();
            var methodSyntax2 = dataSource.OfType<string>().ToList();

            var querySyntax = (from source in dataSource
                               where source is int
                               select source).ToList();
            var querySyntax2 = (from source in dataSource
                               where source is String
                               select source).ToList();

            Console.ReadLine();
        }
    }
}
