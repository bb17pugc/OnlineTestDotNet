using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class AppearedQuestionsDetails
    {
        public int ID { get; set; }
        public string OtA { get; set; }
        public string OtB { get; set; }
        public string OtC { get; set; }
        public string OtD { get; set; }
        public string Correct { get; set; }
        public Question question { get; set; }
        public AppearedCandidate appearedCandidate { get; set; }
    }
}
