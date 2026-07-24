namespace Business_Layer.DTOs
{
    public class SpecializationStatisticsDto
    {
        public string SpecializationName { get; set; } = null!;
        public int StudentsCount { get; set; }
        public double Percentage { get; set; }

    }
}
