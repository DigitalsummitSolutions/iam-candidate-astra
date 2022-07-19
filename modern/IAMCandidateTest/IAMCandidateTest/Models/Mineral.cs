using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IAMCandidateTest.Models
{
    public class Mineral
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Precision(18, 2)]
        public decimal Hardness { get; set; }
        public CategoryType CategoryType { get; set; }
        public Luster Luster { get; set; }
        public MineralColor Color { get; set; }
        public Streak Streak { get; set; }
        [Precision(18, 2)]
        public decimal SpecificGravity { get; set; }
        public Diaphaneity Diaphaneity { get; set; }
    }
}
