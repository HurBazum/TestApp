using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Entities.Base
{
    public class Person : BaseEntity
    {
        public string LastName { get; set; }
        public string Patrionymic { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
