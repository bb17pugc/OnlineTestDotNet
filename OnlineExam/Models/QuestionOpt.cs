using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Models
{
    public class QuestionOpt
    {
        public int ID { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Question { get; set; }

        [Required]
        public string Option { get; set; }
        [Required]
        public string Correct { get; set; }
        public Question question { get; set; }
    }
}
