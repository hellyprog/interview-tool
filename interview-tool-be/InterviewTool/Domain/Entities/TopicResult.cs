namespace InterviewTool.Domain.Entities
{
    public class TopicResult
    {
        public int TopicResultId { get; set; }
        public int? Point { get; set; }
        public int? TopicId { get; set; }
        public int ChapterResultId { get; set; }
        public Topic Topic { get; set; }
        public ChapterResult ChapterResult { get; set; }
    }
}
