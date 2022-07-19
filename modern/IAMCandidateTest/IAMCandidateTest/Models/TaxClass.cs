﻿using System.ComponentModel.DataAnnotations;

namespace IAMCandidateTest.Models
{
    public class TaxClass
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}