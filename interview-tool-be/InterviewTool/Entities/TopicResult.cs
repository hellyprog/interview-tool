namespace InterviewTool.Entities
{
    public class TopicResult
    {
        public int TopicAnswerId { get; set; }
        public int? Point { get; set; }
        public double Weight { get; set; }
        public ChapterResult ChapterResult { get; set; }
    }
}
