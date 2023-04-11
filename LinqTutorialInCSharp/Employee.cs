using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorialInCSharp
{
    public class Employee
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public String Email { set; get; }
        public List<Techs> Programming { set; get; }
    }
}
