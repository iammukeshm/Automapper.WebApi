using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automapper.WebApi.DTOs
{
    public class DeveloperDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Experience { get; set; }

        public decimal Compensation { get; set; }
        public bool IsEmployed { get; set; }

        public AddressDTO Address { get; set; }
    }
}
