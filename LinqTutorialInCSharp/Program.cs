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

            var methodSyntaxForInt = dataSourceInt.OrderBy(x => x).ToList();

            var methodSyntaxForString = dataSourceString.OrderBy(x => x).ToList();

            var querySyntaxForInt = (from qs in dataSourceInt
                                     orderby qs
                                     select qs).ToList();

            var querySyntaxForString = (from qs in dataSourceString
                                     orderby qs
                                     select qs).ToList();

            Console.ReadLine();
        }
    }
}
