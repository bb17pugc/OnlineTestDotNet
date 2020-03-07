using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Models
{
    public class Apearing
    {
        public Candidate candidate { get; set; }
        public Subject subject { get; set; }

        public List<Question> questions { get; set; }
    }
}
