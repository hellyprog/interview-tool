namespace InterviewTool.Domain.Entities
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public Chapter Chapter { get; set; }
    }
}
