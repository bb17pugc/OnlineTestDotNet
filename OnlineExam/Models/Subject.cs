using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Models
{
    public class Subject
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Marks { get; set; }
        [Required]
        public string Time { get; set; }
    }
}
