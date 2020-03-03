using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class Cleared
    {
        public int ID { get; set; }
        public Candidate candidate { get; set; }
        public Subject subject { get; set; }
        public int  Score { get; set; }
    }
}
