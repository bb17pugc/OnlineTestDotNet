﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Models
{
    public class AppearedCandidate
    {
        public int ID { get; set; }
        public Candidate candidate { get; set; }
        public Subject subject { get; set; }

    }
}
