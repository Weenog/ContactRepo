using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListApp.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string LastName { get; set;}
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int TelNr { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
    }
}
