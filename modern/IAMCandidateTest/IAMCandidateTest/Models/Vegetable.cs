using System.ComponentModel.DataAnnotations;

namespace IAMCandidateTest.Models
{
    public class Vegetable
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public EdiblePart EdiblePart {get;set;}
        public bool? IsBotanicalFruit { get; set; }
        public CategoryType CategoryType { get; set; }
    }
}
