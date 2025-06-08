namespace BlazorApp1.Components.Models
{
    public class Assessments
    {
        public string? Assessment { get; set; }
        public int WeightedMark { get; set; } = 0;
        public int Score { get; set; } = 0;
    }
}
// This class represents an assessment with properties for the assessment name, weighted mark, and score.