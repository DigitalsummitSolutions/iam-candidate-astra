namespace IAMCandidateTest.Models
{
    public class Mineral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Hardness { get; set; }
        public Luster Luster { get; set; }
        public MineralColor Color { get; set; }
        public Streak Streak { get; set; }
        public decimal SpecificGravity { get; set; }
        public Diaphaneity Diaphaneity { get; set; }
    }
}
