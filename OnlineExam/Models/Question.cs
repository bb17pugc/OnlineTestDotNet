using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Models
{
    public class Question
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Subject { get; set; }
        public Subject subjectId { get; set; }
    }
}
