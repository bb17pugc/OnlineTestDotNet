using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class Candidate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public ApplicationUser applicationUser { get; set; }
    }
}
