using System.ComponentModel.DataAnnotations;

namespace IAMCandidateTest.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int LegCount { get; set; }
        public int WingCount { get; set; }
        public bool? CanFly { get; set; }
        public CategoryType CategoryType { get; set; }
        public TaxPhylum TaxPhylum { get; set; }
        public TaxClass TaxClass { get; set; }
        public TaxOrder TaxOrder { get; set; }
        public TaxFamily TaxFamily { get; set; }
        public TaxGenus TaxGenus { get; set; }
        public TaxSpecies TaxSpecies { get; set; }

    }
}
