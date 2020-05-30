using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automapper.WebApi.Models
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Experience { get; set; }

        public decimal Salary { get; set; }
        public Address Address { get; set; }
    }
}
