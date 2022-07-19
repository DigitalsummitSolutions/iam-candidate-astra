using Microsoft.EntityFrameworkCore;

namespace IAMCandidateTest.Models.ViewModels
{
    public class MineralViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Hardness { get; set; }
        public string Luster { get; set; }
        public string Color { get; set; }
        public string Streak { get; set; }
        public decimal SpecificGravity { get; set; }
        public string Diaphaneity { get; set; }
    }
}
