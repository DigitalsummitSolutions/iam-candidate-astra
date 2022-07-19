using System.ComponentModel.DataAnnotations;

namespace IAMCandidateTest.Models
{
    public class CategoryType
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
