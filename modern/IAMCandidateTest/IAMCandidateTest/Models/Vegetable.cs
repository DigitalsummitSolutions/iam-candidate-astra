namespace IAMCandidateTest.Models
{
    public class Vegetable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EdiblePart EdiblePart {get;set;}
        public bool IsBotanicalFruit { get; set; }
    }
}
